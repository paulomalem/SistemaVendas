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

namespace SistemaVendas.WPF
{
    /// <summary>
    /// Lógica interna para FormVendaAlterar.xaml
    /// </summary>
    public partial class FormVendaAlterar : Window
    {
        List<ItemVenda> ItemVendas = new List<ItemVenda>();
        List<Produto> listaProduto = null;
        ClienteController clienteCtrl = null;
        ItemVendaController itemVendaCtrl = null;
        double total = 0;
        int IdCliente;
        int IdVenda;

        public FormVendaAlterar(Venda venda)
        {
            InitializeComponent();

            textValorTotal.Text = venda.ValorTotal.ToString();
            total = venda.ValorTotal;
            textCodigoVenda.Text = venda.Id.ToString();
            IdCliente = venda.Id_cliente;
            textData.Text = venda.Data.ToString();
            IdVenda = venda.Id;
            textData.Text = venda.Data.ToString();
            textClienteNome.Text = PegarClientePeloId(venda).Nome.ToString();
            CarregaDadosBancoAbrirTela();
            ItemVendas = RetornaListaDoBanco(venda.Id);
        }


        private void CarregaDadosBancoAbrirTela()
        {

            listaProdutoVenda.ItemsSource = null;

            int x = (Convert.ToInt32((textCodigoVenda.Text).ToString()));
            var teste = RetornaListaDoBanco(x);
            listaProdutoVenda.ItemsSource = teste;
            //lista do banco de dados
        }

        private void CarregaDados()
        {
            //RetornaListaDoBanco
        }

        private Cliente PegarClientePeloId(Venda venda)
        {
            clienteCtrl = new ClienteController();

            Cliente cliente = clienteCtrl.ListarPeloID(venda.Id_cliente);

            return cliente;
        }

        private List<ItemVenda> RetornaListaDoBanco(int id)
        {

            itemVendaCtrl = new ItemVendaController();

            return itemVendaCtrl.RetornaListaDaVenda(id);
        }

        private void comboProduto_Loaded(object sender, RoutedEventArgs e)
        {

            ProdutoController ctrl = new ProdutoController();

            listaProduto = ctrl.Listar();

            comboProduto.ItemsSource = listaProduto;
        }

        private void comboProduto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboProduto.SelectedItem == null)
            {
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

            Produto data = (Produto)comboProduto.SelectedItem;

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

            Produto produtoSelecionado = new Produto();
            produtoSelecionado = (Produto)comboProduto.SelectedItem; //objeto produto


            //CALCULA VALOR TOTAL
            var quantidade = textQuantidade.Text.ToString(); //Quantidade
            var valorTotalProduto = produtoSelecionado.Valor * Convert.ToInt32(quantidade); // Valor Total de Cada Produto = ProdutoxQuantidade
            total = valorTotalProduto + total;

            textValorTotal.Text = (total).ToString();

            ItemVendas.Add(new ItemVenda()
            {
                Id_Produto = produtoSelecionado.Id,
                Id_Venda = IdVenda,
                Descricao_Produto = produtoSelecionado.Descricao,
                Quantidade = Convert.ToInt32(textQuantidade.Text),
                Valor_Produto = Convert.ToDouble(produtoSelecionado.Valor.ToString())
            });

            listaProdutoVenda.ItemsSource = null;

            listaProdutoVenda.ItemsSource = ItemVendas;

            textQuantidade.Text = String.Empty;
            textValor.Text = String.Empty;

            comboProduto.Text = "";
        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {

            ItemVendaController itemVendaCtrl = new ItemVendaController();
            VendaController vendaCtrl = new VendaController();


            itemVendaCtrl.DeletaAnteriores(IdVenda);

            if (itemVendaCtrl.Salvar(ItemVendas, IdVenda))
            {


                vendaCtrl.AtualizarVenda(IdVenda, total);

                MessageBox.Show("Parabens!", "Salvo com sucesso", MessageBoxButton.OK);

                this.Close();
            }
        }

        private void DeletarItemVenda(int id)
        {
            itemVendaCtrl.DeletarUnicoItem(id);
        }



        private void btnDeletarProduto_Click(object sender, RoutedEventArgs e)
        {


            var objetoItemVenda = (ItemVenda)listaProdutoVenda.SelectedItem;

            if (objetoItemVenda == null)
            {
                MessageBox.Show("Selecione um Produto");
                return;
            }

            if (ItemVendas.Remove(objetoItemVenda))
            {
                var valorItemVenda = objetoItemVenda.Valor_Produto;

                total = total - (objetoItemVenda.Valor_Produto * objetoItemVenda.Quantidade);
                
                //DeletarItemVenda(id);

                listaProdutoVenda.ItemsSource = null;

                listaProdutoVenda.ItemsSource = ItemVendas;

                textValorTotal.Text = (total).ToString();

            }
            


        }



        private void textData_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listaProdutoVenda_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}


