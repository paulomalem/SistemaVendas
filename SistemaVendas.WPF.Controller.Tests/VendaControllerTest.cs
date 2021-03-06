using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.Controller;

namespace SistemaVendas.WPF.Controller.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para VendaController</summary>
    [TestClass]
    [PexClass(typeof(VendaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class VendaControllerTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        public VendaController ConstructorTest()
        {
            VendaController target = new VendaController();
            return target;
            // TODO: adicionar declarações para método VendaControllerTest.ConstructorTest()
        }

        /// <summary>Stub de teste para AtualizarVenda(Int32, Double)</summary>
        [PexMethod]
        public void AtualizarVendaTest(
            [PexAssumeUnderTest]VendaController target,
            int id,
            double total
        )
        {
            target.AtualizarVenda(id, total);
            // TODO: adicionar declarações para método VendaControllerTest.AtualizarVendaTest(VendaController, Int32, Double)
        }

        /// <summary>Stub de teste para ExcluirVenda(Int32)</summary>
        [PexMethod]
        public bool ExcluirVendaTest([PexAssumeUnderTest]VendaController target, int id)
        {
            bool result = target.ExcluirVenda(id);
            return result;
            // TODO: adicionar declarações para método VendaControllerTest.ExcluirVendaTest(VendaController, Int32)
        }

        /// <summary>Stub de teste para Listar()</summary>
        [PexMethod]
        public List<Venda> ListarTest([PexAssumeUnderTest]VendaController target)
        {
            List<Venda> result = target.Listar();
            return result;
            // TODO: adicionar declarações para método VendaControllerTest.ListarTest(VendaController)
        }

        /// <summary>Stub de teste para Salvar(Venda)</summary>
        [PexMethod]
        public int SalvarTest([PexAssumeUnderTest]VendaController target, Venda venda)
        {
            int result = target.Salvar(venda);
            return result;
            // TODO: adicionar declarações para método VendaControllerTest.SalvarTest(VendaController, Venda)
        }
    }
}
