using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.DAO;

namespace SistemaVendas.WPF.DAO.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para VendaDAO</summary>
    [TestClass]
    [PexClass(typeof(VendaDAO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class VendaDAOTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        public VendaDAO ConstructorTest()
        {
            VendaDAO target = new VendaDAO();
            return target;
            // TODO: adicionar declarações para método VendaDAOTest.ConstructorTest()
        }

        /// <summary>Stub de teste para AtualizarVenda(Int32, Double)</summary>
        [PexMethod]
        public void AtualizarVendaTest(
            [PexAssumeUnderTest]VendaDAO target,
            int id,
            double total
        )
        {
            target.AtualizarVenda(id, total);
            // TODO: adicionar declarações para método VendaDAOTest.AtualizarVendaTest(VendaDAO, Int32, Double)
        }

        /// <summary>Stub de teste para Excluir(Int32)</summary>
        [PexMethod]
        public int ExcluirTest([PexAssumeUnderTest]VendaDAO target, int id)
        {
            int result = target.Excluir(id);
            return result;
            // TODO: adicionar declarações para método VendaDAOTest.ExcluirTest(VendaDAO, Int32)
        }

        /// <summary>Stub de teste para ListarVenda()</summary>
        [PexMethod]
        public List<Venda> ListarVendaTest([PexAssumeUnderTest]VendaDAO target)
        {
            List<Venda> result = target.ListarVenda();
            return result;
            // TODO: adicionar declarações para método VendaDAOTest.ListarVendaTest(VendaDAO)
        }

        /// <summary>Stub de teste para Salvar(Venda)</summary>
        [PexMethod]
        public int SalvarTest([PexAssumeUnderTest]VendaDAO target, Venda venda)
        {
            int result = target.Salvar(venda);
            return result;
            // TODO: adicionar declarações para método VendaDAOTest.SalvarTest(VendaDAO, Venda)
        }
    }
}
