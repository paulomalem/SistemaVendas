using SistemaVendas.WPF.DAO;
using SistemaVendas.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.WPF.Controller
{
    public class ItemVendaController
    {

        ItemVendaDAO itemVendaDAO = null;

        public ItemVendaController()
        {
            itemVendaDAO = new ItemVendaDAO();
        }

        public bool Salvar(List<ItemVenda> listItemVenda, int IdVenda)
        {

            try
            {
                foreach (ItemVenda item in listItemVenda)
                {

                    item.Id_Venda = IdVenda;
                    itemVendaDAO.Adicionar(item);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ItemVenda> RetornaListaDaVenda(int id_venda)
        {
            return itemVendaDAO.ListaItensDaVenda(id_venda);
        }

        public void DeletaAnteriores(int id)
        {
            itemVendaDAO.ExcluirItensAnteriores(id);
        }

        public void DeletarUnicoItem(int id)
        {
            itemVendaDAO.ExcluirItemDaVenda(id);
        }

    }
}
