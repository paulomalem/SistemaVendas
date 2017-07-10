using System;
using System.Collections.Generic;
using System.Data;
using SistemaVendas.Banco;
using System.Data.SqlClient;
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
using SistemaVendas.WPF.Controller;
using SistemaVendas.WPF.Models;

namespace SistemaVendas.WPF
{
    /// <summary>
    /// Lógica interna para FormClienteNovo.xaml
    /// </summary>
    public partial class FormClienteNovo : Window
    {
        int IdCliente = 0;
        public FormClienteNovo()
        {
            InitializeComponent();
        }

        public FormClienteNovo(Cliente cliente)
        {
            InitializeComponent();

            textNome.Text = cliente.Nome;
            textEndereco.Text = cliente.Endereco;
            textCidade.Text = cliente.Cidade;
            textUF.Text = cliente.Uf;
            textCodigo.Text = cliente.Id.ToString();
            IdCliente = cliente.Id;
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
            if (textNome.Text == "" ||  textEndereco.Text == "" || textCidade.Text == "" || textUF.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            } 

            //VALIDAÇÃO NÚMEROS EM CAMPOS DE LETRAS

            if ((this.contemNumeros(textNome.Text)) ||
                    (this.contemNumeros(textCidade.Text)) || 
                         (this.contemNumeros(textUF.Text)))
            {
                MessageBox.Show("Preencha os campos corretamente");
                return;
            }


            Cliente cliente = new Cliente();

                cliente.Nome = textNome.Text.ToString();
                cliente.Endereco = textEndereco.Text.ToString();
                cliente.Cidade = textCidade.Text.ToString();
                cliente.Uf = textUF.Text.ToString();

                ClienteController clientCtrl = new ClienteController();

            if (IdCliente != 0)
            {
                cliente.Id = IdCliente;
            }

            clientCtrl.Salvar(cliente);



                textNome.Text = "";
                textEndereco.Text = "";
                textCidade.Text = "";
                textUF.Text = "";

            //MessageBox.Show(textoAlert);

            MessageBox.Show("Cliente Salvo com Sucesso!");

            this.Close();
            
        }

    }
}
