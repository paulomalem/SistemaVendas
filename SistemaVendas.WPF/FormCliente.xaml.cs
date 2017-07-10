using SistemaVendas.WPF.Controller;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para FormCliente.xaml
    /// </summary>
    public partial class FormCliente : Window
    {
        public ClienteController ctrl = null;
        public FormCliente()
        {
            InitializeComponent();

            ctrl = new ClienteController();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void btnClienteNovo_Click(object sender, RoutedEventArgs e)
        {
            var abriJanela = new FormClienteNovo();
            abriJanela.ShowDialog();


            CarregueElementosDoBancoDeDados();


        }
        
        private void btnClienteAlterar_Click(object sender, RoutedEventArgs e)
        {
            var objetoCliente = (Cliente)listaCliente.SelectedItem;

            if (objetoCliente == null || objetoCliente.Id <= 0) {
                MessageBox.Show("Selecione um Cliente");
                return;
            }
            
            var abriJanela = new FormClienteNovo(objetoCliente);
            abriJanela.ShowDialog();

            CarregueElementosDoBancoDeDados();


        }

        private void CarregueElementosDoBancoDeDados()
        {
           
            List<Cliente> lista = new List<Cliente>();

            listaCliente.ItemsSource = null;

            listaCliente.ItemsSource = ctrl.Listar();
        }
        

        private void btnClienteExcluir_Click(object sender, RoutedEventArgs e)
        {

            var objetoCliente = (Cliente)listaCliente.SelectedItem;

            if (objetoCliente == null || objetoCliente.Id <= 0) {
                MessageBox.Show("Selecione um Cliente");
                return;
            }

            if (!ctrl.Remover(objetoCliente)) {
                MessageBox.Show("Não foi possivel deletar este registro. Existe Restrição!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            CarregueElementosDoBancoDeDados();
            
        }

        private void LoadedListView(object sender, RoutedEventArgs e)
        {

            CarregueElementosDoBancoDeDados();

        }

        private void teste(object sender, DependencyPropertyChangedEventArgs e)
        {
            CarregueElementosDoBancoDeDados();

        }
    }
}
