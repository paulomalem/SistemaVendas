using SistemaVendas.WPF.DAO;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.Controller
{
    public class ProdutoController
    {

        ProdutoDAO produtoDAO = null;
        public ProdutoController()
        {
            produtoDAO = new ProdutoDAO();
        }

        public void Salvar(Produto produto)
        {
            produtoDAO.Adicionar(produto);
        }

        public bool Remover(Produto produto)
        {
            try
            {
                produtoDAO.Excluir(produto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Produto> Listar()
        {
            var lista = produtoDAO.ListaProduto();

            return lista;
        }
    }
}
