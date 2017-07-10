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
    class ProdutoDAO
    {
        SqlConnection db = null;

        public ProdutoDAO()
        {
            var banco = new BancoConexao();
            db = banco.Conexao();

        }

        public int Adicionar(Produto produto)
        {

            String pathNovo = "INSERT INTO Produto(descricao, quantidade, valor)" +
                " VALUES(@Descricao, @Quantidade, @Valor)";

            String pathUpdate = "UPDATE Produto SET descricao = @Descricao," +
                " quantidade = @Quantidade, valor = @Valor WHERE id = @Id";

            var path = produto.Id != 0 ? pathUpdate : pathNovo;

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;

                if (produto.Id != 0)
                {
                    cmd.Parameters.AddWithValue("@Id", produto.Id);
                }

                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@Valor", produto.Valor);

                return cmd.ExecuteNonQuery();
            }
        }

        public int Excluir(Produto produto)
        {
            String path = "DELETE FROM Produto " +
                "WHERE id = @PrimeiroParametro";

            using (var cmd = new SqlCommand())
            {
                cmd.Connection = db;
                cmd.CommandText = path;
                cmd.Parameters.AddWithValue("@PrimeiroParametro", produto.Id);

                return cmd.ExecuteNonQuery();
            }
        }

        public List<Produto> ListaProduto()
        {
            using (var cmd = new SqlCommand())
            {
                SqlDataAdapter ada = new SqlDataAdapter("select * from Produto", db);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                List<Produto> produtoLista = new List<Produto>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    produto.Descricao = dt.Rows[i]["Descricao"].ToString();
                    produto.Quantidade = dt.Rows[i]["Quantidade"].ToString();
                    produto.Valor = Convert.ToDouble(dt.Rows[i]["Valor"]);
                    produtoLista.Add(produto);
                }

                return produtoLista;
            }

        }
    }
}
