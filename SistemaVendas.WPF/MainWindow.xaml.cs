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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaVendas.WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            var janelaCliente = new FormCliente();
            janelaCliente.Show();
        }

        private void btnProduto_Click(object sender, RoutedEventArgs e)
        {
            var janelaProduto = new FormProduto();
            janelaProduto.Show();

        }

        private void btnVenda_Click(object sender, RoutedEventArgs e)
        {
            var abriJanela = new FormVenda();
            abriJanela.ShowDialog();
        }
    }
}
