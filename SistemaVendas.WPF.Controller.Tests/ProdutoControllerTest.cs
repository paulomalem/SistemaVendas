using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.Controller;

namespace SistemaVendas.WPF.Controller.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ProdutoController</summary>
    [TestClass]
    [PexClass(typeof(ProdutoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProdutoControllerTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        public ProdutoController ConstructorTest()
        {
            ProdutoController target = new ProdutoController();
            return target;
            // TODO: adicionar declarações para método ProdutoControllerTest.ConstructorTest()
        }

        /// <summary>Stub de teste para Listar()</summary>
        [PexMethod]
        public List<Produto> ListarTest([PexAssumeUnderTest]ProdutoController target)
        {
            List<Produto> result = target.Listar();
            return result;
            // TODO: adicionar declarações para método ProdutoControllerTest.ListarTest(ProdutoController)
        }

        /// <summary>Stub de teste para Remover(Produto)</summary>
        [PexMethod]
        public bool RemoverTest([PexAssumeUnderTest]ProdutoController target, Produto produto)
        {
            bool result = target.Remover(produto);
            return result;
            // TODO: adicionar declarações para método ProdutoControllerTest.RemoverTest(ProdutoController, Produto)
        }

        /// <summary>Stub de teste para Salvar(Produto)</summary>
        [PexMethod]
        public void SalvarTest([PexAssumeUnderTest]ProdutoController target, Produto produto)
        {
            target.Salvar(produto);
            // TODO: adicionar declarações para método ProdutoControllerTest.SalvarTest(ProdutoController, Produto)
        }
    }
}
