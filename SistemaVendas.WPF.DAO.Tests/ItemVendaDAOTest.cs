using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.DAO;

namespace SistemaVendas.WPF.DAO.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ItemVendaDAO</summary>
    [TestClass]
    [PexClass(typeof(ItemVendaDAO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ItemVendaDAOTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        internal ItemVendaDAO ConstructorTest()
        {
            ItemVendaDAO target = new ItemVendaDAO();
            return target;
            // TODO: adicionar declarações para método ItemVendaDAOTest.ConstructorTest()
        }

        /// <summary>Stub de teste para Adicionar(ItemVenda)</summary>
        [PexMethod]
        internal int AdicionarTest([PexAssumeUnderTest]ItemVendaDAO target, ItemVenda itemVenda)
        {
            int result = target.Adicionar(itemVenda);
            return result;
            // TODO: adicionar declarações para método ItemVendaDAOTest.AdicionarTest(ItemVendaDAO, ItemVenda)
        }

        /// <summary>Stub de teste para ExcluirItemDaVenda(Int32)</summary>
        [PexMethod]
        internal int ExcluirItemDaVendaTest([PexAssumeUnderTest]ItemVendaDAO target, int id)
        {
            int result = target.ExcluirItemDaVenda(id);
            return result;
            // TODO: adicionar declarações para método ItemVendaDAOTest.ExcluirItemDaVendaTest(ItemVendaDAO, Int32)
        }

        /// <summary>Stub de teste para ExcluirItensAnteriores(Int32)</summary>
        [PexMethod]
        internal void ExcluirItensAnterioresTest([PexAssumeUnderTest]ItemVendaDAO target, int id)
        {
            target.ExcluirItensAnteriores(id);
            // TODO: adicionar declarações para método ItemVendaDAOTest.ExcluirItensAnterioresTest(ItemVendaDAO, Int32)
        }

        /// <summary>Stub de teste para ListaItensDaVenda(Int32)</summary>
        [PexMethod]
        internal List<ItemVenda> ListaItensDaVendaTest([PexAssumeUnderTest]ItemVendaDAO target, int idVenda)
        {
            List<ItemVenda> result = target.ListaItensDaVenda(idVenda);
            return result;
            // TODO: adicionar declarações para método ItemVendaDAOTest.ListaItensDaVendaTest(ItemVendaDAO, Int32)
        }
    }
}
