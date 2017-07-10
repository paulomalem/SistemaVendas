using System;
using SistemaVendas.Banco;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaVendas.WPF.Models;
using System.Data;

namespace SistemaVendas.WPF.DAO
{
    class ClienteDAO
    {
        SqlConnection db = null;

        public ClienteDAO()
        {
            var banco = new BancoConexao();
            db = banco.Conexao();

        }

        public int Adicionar(Cliente cliente)
        {

            String pathNovo = "INSERT INTO Cliente(nome, endereco, cidade, uf)" +
                " VALUES(@Nome, @Endereco, @Cidade, @Uf)";


            String pathUpdate = "UPDATE Cliente SET nome = @Nome," +
                " endereco = @Endereco, cidade = @Cidade, uf = @Uf WHERE id = @Id";

            var path = cliente.Id != 0 ? pathUpdate : pathNovo;

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;

                if (cliente.Id != 0)
                {
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                }

                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Uf", cliente.Uf);

                return cmd.ExecuteNonQuery();
            }
        }

        public int Excluir(Cliente cliente)
        {
            String path = "DELETE FROM Cliente " +
                "WHERE id = @Id";

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;
                cmd.Parameters.AddWithValue("@Id", cliente.Id);

                return cmd.ExecuteNonQuery();
            }
        }

        public List<Cliente> ListaCliente()
        {
            using (var cmd = new SqlCommand())
            {
                SqlDataAdapter ada = new SqlDataAdapter("select * from Cliente", db);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                List<Cliente> clienteLista = new List<Cliente>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    cliente.Nome = dt.Rows[i]["Nome"].ToString();
                    cliente.Endereco = dt.Rows[i]["Endereco"].ToString();
                    cliente.Cidade = dt.Rows[i]["Cidade"].ToString();
                    cliente.Uf = dt.Rows[i]["Uf"].ToString();
                    clienteLista.Add(cliente);
                }

                return clienteLista;
            }

        }

        public Cliente ListaClientePeloId(int id)
        {

            using (var cmd = new SqlCommand())
            {
                SqlCommand sqlcmd = new SqlCommand("select * from Cliente where id = " + id, db);
                Cliente cliente = new Cliente();

                DataTable dt = new DataTable();

                SqlDataReader reader = sqlcmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente.Id = Convert.ToInt32(reader["Id"]);
                        cliente.Nome = reader["Nome"].ToString();
                        cliente.Endereco = reader.ToString();
                        cliente.Cidade = reader["Cidade"].ToString();
                        cliente.Uf = reader["Uf"].ToString();
                    }

                    return cliente;

                }
                else
                {
                    return cliente;
                }
            }
        }
    }
}