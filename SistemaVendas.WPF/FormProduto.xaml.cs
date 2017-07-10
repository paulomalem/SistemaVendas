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
    /// Lógica interna para FormProduto.xaml
    /// </summary>
    public partial class FormProduto : Window
    {

        public ProdutoController ctrl = null;
        public FormProduto()
        {
            InitializeComponent();

            ctrl = new ProdutoController();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnClienteAlterar_Click(object sender, RoutedEventArgs e)
        {
            var objetoProduto = (Produto)listaProduto.SelectedItem;

            if (objetoProduto == null || objetoProduto.Id <= 0)
            {
                MessageBox.Show("Selecione um Produto");
                return;
            }

            var abriJanela = new FormProdutoNovo(objetoProduto);
            abriJanela.ShowDialog();
            CarregueElementosDoBancoDeDados();

        }

        private void CarregueElementosDoBancoDeDados()
        {

            List<Produto> lista = new List<Produto>();

            listaProduto.ItemsSource = null;

            listaProduto.ItemsSource = ctrl.Listar();
        }


        private void btnClienteExcluir_Click(object sender, RoutedEventArgs e)
        {

            var objetoProduto = (Produto)listaProduto.SelectedItem;


            if (objetoProduto == null || objetoProduto.Id <= 0)
            {
                MessageBox.Show("Selecione um Produto");
                return;
            }

            if (!ctrl.Remover(objetoProduto))
            {
                MessageBox.Show("Não foi possivel deletar este registro. Existe Restrição!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }



            CarregueElementosDoBancoDeDados();

        }

        private void LoadedListView(object sender, RoutedEventArgs e)
        {

            CarregueElementosDoBancoDeDados();

        }

        private void btnProdutoNovo_Click(object sender, RoutedEventArgs e)
        {
            var abriJanela = new FormProdutoNovo();
            abriJanela.ShowDialog();

            CarregueElementosDoBancoDeDados();
        }
    }
}
