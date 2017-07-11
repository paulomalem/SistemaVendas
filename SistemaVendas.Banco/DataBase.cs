using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Banco
{
    public class BancoConexao
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public SqlConnection Conexao()
        {
            // STRING DE CONEXÃO PARA DB LOCAL
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\#Dev\\#ESL\\SistemaVendas\\SistemaVendas.Banco\\Database.mdf;Integrated Security=True");
            //                                                                                \\D:\\#Dev\\#ESL\\
            //                                                                                 Este pedaço do código antes da pasta
            //                                                                                 \\SistemaVendas deverá estar preenchido
            //                                                                                 Com o diretório que você colocou o projeto
            //                                                                                 Referente a sua máquina
            // Exemplo de conexão:
            //
            //  con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\MeuComputador\MinhaPasta\\SistemaVendas\\SistemaVendas.Banco\\Database.mdf;Integrated Security=True");


            //SQL SERVER
            //Data Source=DESKTOP-3TUDSQ3;Initial Catalog=SistemaVendas;Integrated Security=True

            //Caso queira rodar em um SQL Server deverá substitui a String SqlConnection por uma String dessa maneira
            // (Data Source=NomeDoServidor;Initial Catalog=SistemaVendas;Integrated Security=True)
            //Neste caso precisa passar o nome do seu servidor, e como está acessando o SQL Server, do jeito que está esta String
            //Estamos acessando pelo logon do Windows, caso você use com usuário e senha deverá coloca-los na String da seguinte forma

            // Data Source=SeuServidor;Initial Catalog=SistemaVendas;UserId=USUARIO; Password=SENHA; Security=True

            con.Open();
            return con;

        }

    }
}
