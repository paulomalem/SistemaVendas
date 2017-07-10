using SistemaVendas.Banco;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.DAO
{

    public class VendaDAO
    {

        SqlConnection db = null;

        public VendaDAO()
        {
            var banco = new BancoConexao();
            db = banco.Conexao();
        }

        public int Salvar(Venda venda)
        {

            String Path = "INSERT INTO Venda (id_cliente, data, numero)" +
                " VALUES (@id_cliente, @data, @numero);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = null;

            using (cmd = new SqlCommand())
            {

                cmd.Connection = db;
                cmd.CommandText = Path;

                cmd.Parameters.AddWithValue("@id_cliente", venda.Id_cliente);
                cmd.Parameters.AddWithValue("@data", venda.Data);
                cmd.Parameters.AddWithValue("@numero", venda.Numero);
            }

            var test = cmd.ExecuteScalar();

            return Convert.ToInt32(test);
        }
        public List<Venda> ListarVenda()
        {
            using (var cmd = new SqlCommand())
            {
                ///numero cliente data e valor


                SqlDataAdapter ada = new SqlDataAdapter("select v.id, v.id_cliente, v.numero, c.nome, v.data, v.valor_total from Venda as v" +
                    " inner join Cliente as c on v.id_cliente = c.id ", db);

                DataTable dt = new DataTable();
                ada.Fill(dt);

                List<Venda> vendaLista = new List<Venda>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Venda venda = new Venda();
                    venda.Numero = Convert.ToInt32(dt.Rows[i]["numero"]);
                    venda.Nome = dt.Rows[i]["nome"].ToString();
                    venda.Data = Convert.ToDateTime(dt.Rows[i]["data"]);
                    venda.Id = Convert.ToInt32(dt.Rows[i]["id"]);
                    venda.Id_cliente = Convert.ToInt32(dt.Rows[i]["id_cliente"]);

                    if (dt.Rows[i]["valor_total"] == DBNull.Value)
                    {
                        venda.ValorTotal = 0;

                    }
                    else
                    {
                        venda.ValorTotal = Convert.ToDouble(dt.Rows[i]["valor_total"]);
                    }

                    vendaLista.Add(venda);
                }

                return vendaLista;
            }

        }

        public void AtualizarVenda(int id, double total)
        {

            String Path = "UPDATE Venda SET valor_total = @ValorTotal WHERE id = @Id";

            using (var cmd = new SqlCommand())
            {

                cmd.Connection = db;
                cmd.CommandText = Path;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@ValorTotal", total);

                cmd.ExecuteNonQuery();
            }
        }

        public int Excluir(int id)
        {
            String path = "DELETE FROM ItemVenda " +
                "WHERE id_venda = @Id";

            String pathVenda = "DELETE FROM Venda " +
                "Where id = @id";

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = pathVenda;
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
