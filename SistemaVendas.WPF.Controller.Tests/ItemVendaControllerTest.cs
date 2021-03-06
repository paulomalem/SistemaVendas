using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.Controller;

namespace SistemaVendas.WPF.Controller.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ItemVendaController</summary>
    [TestClass]
    [PexClass(typeof(ItemVendaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ItemVendaControllerTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        public ItemVendaController ConstructorTest()
        {
            ItemVendaController target = new ItemVendaController();
            return target;
            // TODO: adicionar declarações para método ItemVendaControllerTest.ConstructorTest()
        }

        /// <summary>Stub de teste para DeletaAnteriores(Int32)</summary>
        [PexMethod]
        public void DeletaAnterioresTest([PexAssumeUnderTest]ItemVendaController target, int id)
        {
            target.DeletaAnteriores(id);
            // TODO: adicionar declarações para método ItemVendaControllerTest.DeletaAnterioresTest(ItemVendaController, Int32)
        }

        /// <summary>Stub de teste para DeletarUnicoItem(Int32)</summary>
        [PexMethod]
        public void DeletarUnicoItemTest([PexAssumeUnderTest]ItemVendaController target, int id)
        {
            target.DeletarUnicoItem(id);
            // TODO: adicionar declarações para método ItemVendaControllerTest.DeletarUnicoItemTest(ItemVendaController, Int32)
        }

        /// <summary>Stub de teste para RetornaListaDaVenda(Int32)</summary>
        [PexMethod]
        public List<ItemVenda> RetornaListaDaVendaTest([PexAssumeUnderTest]ItemVendaController target, int id_venda)
        {
            List<ItemVenda> result = target.RetornaListaDaVenda(id_venda);
            return result;
            // TODO: adicionar declarações para método ItemVendaControllerTest.RetornaListaDaVendaTest(ItemVendaController, Int32)
        }

        /// <summary>Stub de teste para Salvar(List`1&lt;ItemVenda&gt;, Int32)</summary>
        [PexMethod]
        public bool SalvarTest(
            [PexAssumeUnderTest]ItemVendaController target,
            List<ItemVenda> listItemVenda,
            int IdVenda
        )
        {
            bool result = target.Salvar(listItemVenda, IdVenda);
            return result;
            // TODO: adicionar declarações para método ItemVendaControllerTest.SalvarTest(ItemVendaController, List`1<ItemVenda>, Int32)
        }
    }
}
