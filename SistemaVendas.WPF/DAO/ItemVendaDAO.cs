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
    class ItemVendaDAO
    {

        SqlConnection db = null;

        public ItemVendaDAO()
        {
            var banco = new BancoConexao();
            db = banco.Conexao();

        }
        public int Adicionar(ItemVenda itemVenda)
        {

            String path = "INSERT INTO ItemVenda(id_venda, descricao_produto, id_produto, valor_produto, " +
                "quantidade)" +
                " VALUES(@id_venda, @descricao_produto, @id_produto, @valor_produto, @quantidade )";

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;
                cmd.Parameters.AddWithValue("@id_venda", itemVenda.Id_Venda);
                cmd.Parameters.AddWithValue("@descricao_produto", itemVenda.Descricao_Produto);
                cmd.Parameters.AddWithValue("@id_produto", itemVenda.Id_Produto);
                cmd.Parameters.AddWithValue("@valor_produto", itemVenda.Valor_Produto);
                cmd.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);

                return cmd.ExecuteNonQuery();
            }
        }

        public List<ItemVenda> ListaItensDaVenda(int idVenda)
        {
            using (var cmd = new SqlCommand())
            {

                SqlCommand sqlcmd = new SqlCommand("SELECT * from ItemVenda where id_venda = " + idVenda, db);

                List<ItemVenda> itemVendaLista = new List<ItemVenda>();


                DataTable dt = new DataTable();
                SqlDataReader reader = sqlcmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.Id = Convert.ToInt32(reader["Id"]);
                        itemVenda.Id_Venda = Convert.ToInt32(reader["Id_Venda"]);
                        itemVenda.Id_Produto = Convert.ToInt32(reader["Id_Produto"].ToString());
                        itemVenda.Valor_Produto = Convert.ToDouble(reader["Valor_Produto"]);
                        itemVenda.Descricao_Produto = reader["Descricao_Produto"].ToString();
                        itemVenda.Quantidade = Convert.ToInt32(reader["Quantidade"]);
                        itemVendaLista.Add(itemVenda);

                    }

                    return itemVendaLista;

                }
                else
                {
                    return itemVendaLista;
                }
            }

        }


        public int ExcluirItemDaVenda(int id)
        {
            String path = "DELETE FROM ItemVenda " +
                "WHERE id = @Id";

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery();
            }
        }


        //_______________________________ALTERAR_______________

        //DELETANDO TODOS OS ITEMS RELACIONADOS A VENDA

        public void ExcluirItensAnteriores(int id)
        {
            String path = "DELETE FROM ItemVenda " +
                "WHERE id_venda = " + id;

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;

                cmd.ExecuteNonQuery();
            }
        }
        //DEPOIS SÓ CHAMAR O MÉTODO ADICIONAR



    }
}
