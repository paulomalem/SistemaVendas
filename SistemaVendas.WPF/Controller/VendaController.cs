using SistemaVendas.WPF.DAO;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.Controller
{

    public class VendaController
    {

        VendaDAO vendaDAO = null;

        public VendaController()
        {
            vendaDAO = new VendaDAO();
        }

        public int Salvar(Venda venda)
        {

            return vendaDAO.Salvar(venda);
        }

        public List<Venda> Listar()
        {
            var lista = vendaDAO.ListarVenda();

            return lista;
        }

        public void AtualizarVenda(int id, double total)
        {

            vendaDAO.AtualizarVenda(id, total);
        }

        public bool ExcluirVenda(int id)
        {

            try
            {
                vendaDAO.Excluir(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
