using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVendas.WPF;
using SistemaVendas.WPF.DAO;
using SistemaVendas.WPF.Models;
using System.Data;

namespace SistemaVendas.WPF.Controller
{
    public class ClienteController
    {

        ClienteDAO clienteDAO = null;
        public ClienteController()
        {
            clienteDAO = new ClienteDAO();        }

        public void Salvar(Cliente cliente)
        {
            clienteDAO.Adicionar(cliente);
        }

        public bool Remover(Cliente cliente)
        {
            try
            {
                clienteDAO.Excluir(cliente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cliente> Listar()
        {
            var lista = clienteDAO.ListaCliente();

            return lista;
        }

        public Cliente ListarPeloID(int id)
        {
            return clienteDAO.ListaClientePeloId(id);

        }
    }
}
