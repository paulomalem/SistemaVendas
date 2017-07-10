using SistemaVendas.WPF.Controller;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaVendas.WPF {
    /// <summary>
    /// Lógica interna para FormVendaNova.xaml
    /// </summary>
    public partial class FormVendaNova : Window {

        List<ItemVenda> ItemVendas = new List<ItemVenda>();
        List<Produto> listaProduto = null;
        int IdVenda = 0;
        double total = 0;

        public FormVendaNova()
        {
            InitializeComponent();
        }

        private void comboCliente_Loaded(object sender, RoutedEventArgs e)
        {

            ClienteController ctrl = new ClienteController();
            
            List<Cliente> listaCliente = ctrl.Listar();

            comboCliente.ItemsSource = listaCliente;

            comboCliente.SelectedIndex = 0;
        }

        private void comboCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            var comboBox = sender as ComboBox;

            string value = comboBox.SelectedItem as string;

        }

        private void btnNovaVenda_Click(object sender, RoutedEventArgs e)
        {
            //Salvar Venda e Retornar o ID
            VendaController vendaCtrl = new VendaController();
            Venda venda = new Venda();

            Cliente data = (Cliente)comboCliente.SelectedItem;

            if (data == null)
            {

                MessageBox.Show(" Selecione um Cliente!");
                return;
            }

            var teste = DateTime.Now;

            venda.Data = teste;
            venda.Id_cliente = data.Id;
            venda.Numero = venda.Id;

            IdVenda = vendaCtrl.Salvar(venda);

            textCodigoVenda.Text = IdVenda.ToString();
            
            ExibirCampos();
        }
        
        public void ExibirCampos()
        {

            comboCliente.IsEnabled = false;
            textValor.IsReadOnly = false;

            btnNovaVenda.IsEnabled = false;
            textCodigoVenda.Visibility = Visibility.Visible;
            textQuantidade.Visibility = Visibility.Visible;
            textValor.Visibility = Visibility.Visible;
            lblCdVenda.Visibility = Visibility.Visible;
            lblProduto.Visibility = Visibility.Visible;
            lblQuantidade.Visibility = Visibility.Visible;
            lblValor.Visibility = Visibility.Visible;
            comboProduto.Visibility = Visibility.Visible;
            btnNovoProduto.Visibility = Visibility.Visible;
            listaProdutoVenda.Visibility = Visibility.Visible;
            lblValorTotal.Visibility = Visibility.Visible;
            textValorTotal.Visibility = Visibility.Visible;
            btnFinalizarVenda.Visibility = Visibility.Visible;
        }

        private void comboProduto_Loaded(object sender, RoutedEventArgs e)
        {

            ProdutoController ctrl = new ProdutoController();
            
            listaProduto = ctrl.Listar();


            comboProduto.ItemsSource = listaProduto;
            
        }

        private void comboProduto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboProduto.SelectedItem == null) {
                return;
            }

            Produto data = (Produto)comboProduto.SelectedItem;

            textValor.Text = data.Valor.ToString();

        }

        //MÉTODOS VALIDAÇÃO LETRAS
        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        //MÉTODO DE VALIDAÇÃO NUMEROS

        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        private void btnNovoProduto_Click(object sender, RoutedEventArgs e)
        {

            Produto data = (Produto)comboProduto.SelectedItem; //objeto produto

            if (data == null)
            {

                MessageBox.Show(" Selecione um Produto!");
                return;
            }
            if (textQuantidade.Text == "")
            {
                MessageBox.Show("Digite uma Quantidade!");
                return;
            }

            if ((this.contemNumeros(textQuantidade.Text)) == false)
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }


            //CALCULA VALOR TOTAL
            var quantidade = textQuantidade.Text;
            var result = data.Valor * Convert.ToInt32(quantidade);
            var valorTotal = (String.IsNullOrEmpty(textValorTotal.Text) ? 0 : Convert.ToInt32(textValorTotal.Text));
            textValorTotal.Text = (result + valorTotal).ToString();
            total = result + valorTotal;

            listaProdutoVenda.Items.Add( new Produto() {
                Id = data.Id,
                Descricao = data.Descricao,
                Quantidade = textQuantidade.Text,
                Valor = result
            });

            ItemVendas.Add(new ItemVenda() {
                Id_Produto = data.Id,
                //ide venda
                Descricao_Produto = data.Descricao,
                Quantidade = Convert.ToInt32(textQuantidade.Text),
                Valor_Produto = Convert.ToDouble(data.Valor.ToString())
            });

            textQuantidade.Text = String.Empty;
            textValor.Text = String.Empty;

            comboProduto.Text = "";

        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e) {

            ItemVendaController itemVendaCtrl = new ItemVendaController();
            VendaController vendaCtrl = new VendaController();


            if (itemVendaCtrl.Salvar(ItemVendas, IdVenda)) {

                vendaCtrl.AtualizarVenda(IdVenda, total);

                MessageBox.Show("Parabens!", "Salvo com sucesso", MessageBoxButton.OK);

                this.Close();
            }
        }
    }
}