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
    /// Lógica interna para FormVenda.xaml
    /// </summary>
    public partial class FormVenda : Window
    {

        public VendaController ctrl = null;


        public FormVenda()
        {
            InitializeComponent();
            ctrl = new VendaController();
        }

        private void btnNovaVenda_Click(object sender, RoutedEventArgs e)
        {
            var abriJanela = new FormVendaNova();
            abriJanela.ShowDialog();
            CarregueElementosDoBancoDeDados();
        }

        private void CarregarListaVenda(object sender, RoutedEventArgs e)
        {
            CarregueElementosDoBancoDeDados();

        }

        private void CarregueElementosDoBancoDeDados()
        {

            List<Venda> lista = new List<Venda>();

            listaVenda.ItemsSource = null;
            
            listaVenda.ItemsSource = ctrl.Listar();
        }

        private void btnAlterarVenda_Click(object sender, RoutedEventArgs e)
        {

            var objetoVenda = (Venda)listaVenda.SelectedItem;


            if (objetoVenda == null || objetoVenda.Id <= 0)
            {
                MessageBox.Show("Selecione uma Venda");
                return;
            }
            var abriJanela = new FormVendaAlterar(objetoVenda);
            abriJanela.ShowDialog();
            CarregueElementosDoBancoDeDados();
        }

        private void btnExcluirVenda_Click(object sender, RoutedEventArgs e)
        {

            var objetoVenda = (Venda)listaVenda.SelectedItem;


            if (objetoVenda == null || objetoVenda.Id <= 0)
            {
                MessageBox.Show("Selecione uma Venda");
                return;
            }

            if (!ctrl.ExcluirVenda(objetoVenda.Id))
            {
                MessageBox.Show("Não foi possivel deletar este registro. Existe Restrição!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            CarregueElementosDoBancoDeDados();
        }
    }
}
