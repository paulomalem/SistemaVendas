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
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\#Dev\\#ESL\\SistemaVendas\\SistemaVendas.Banco\\Database.mdf;Integrated Security=True");
            con.Open();

            //SQL SERVER
            //Data Source=DESKTOP-3TUDSQ3;Initial Catalog=SistemaVendas;Integrated Security=True
            

            return con;

        }

    }
}
