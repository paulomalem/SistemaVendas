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
    /// Lógica interna para FormProdutoNovo.xaml
    /// </summary>
    public partial class FormProdutoNovo : Window
    {

        int IdProduto = 0;
        public FormProdutoNovo()
        {
            InitializeComponent();
        }

        public FormProdutoNovo(Produto produto)
        {
            InitializeComponent();

            textDescricao.Text = produto.Descricao;
            textValor.Text = produto.Valor.ToString();
            textQuantidade.Text = produto.Quantidade.ToString(); ;
            textCodigo.Text = produto.Id.ToString();
            IdProduto = produto.Id;
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


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            //VALIDAÇÃO CAMPOS VAZIOS
            if (textDescricao.Text == "" || textValor.Text == "" || textQuantidade.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }

            //VALIDAÇÃO LETRAS EM CAMPOS NUMÉRICOS

            if ((this.contemNumeros(textQuantidade.Text)) == false || (this.contemNumeros(textValor.Text)) == false)
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }

            Produto produto = new Produto();

            produto.Descricao = textDescricao.Text.ToString();
            produto.Valor = Convert.ToDouble(textValor.Text);
            produto.Quantidade = textQuantidade.Text.ToString();

            ProdutoController produtoCtrl = new ProdutoController();

            if (IdProduto != 0)
            {
                produto.Id = IdProduto;
            }

            produtoCtrl.Salvar(produto);

            textDescricao.Text = "";
            textValor.Text = "";
            textQuantidade.Text = "";
            textCodigo.Text = "";
            textQuantidade.Text = "";

            MessageBox.Show("Produto Salvo com Sucesso!");

            this.Close();
        }
        
    }
}
