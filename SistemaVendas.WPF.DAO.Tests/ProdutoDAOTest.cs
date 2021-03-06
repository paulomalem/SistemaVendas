using System.Collections.Generic;
using SistemaVendas.WPF.Models;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.DAO;

namespace SistemaVendas.WPF.DAO.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ProdutoDAO</summary>
    [TestClass]
    [PexClass(typeof(ProdutoDAO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProdutoDAOTest
    {

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        internal ProdutoDAO ConstructorTest()
        {
            ProdutoDAO target = new ProdutoDAO();
            return target;
            // TODO: adicionar declarações para método ProdutoDAOTest.ConstructorTest()
        }

        /// <summary>Stub de teste para Adicionar(Produto)</summary>
        [PexMethod]
        internal int AdicionarTest([PexAssumeUnderTest]ProdutoDAO target, Produto produto)
        {
            int result = target.Adicionar(produto);
            return result;
            // TODO: adicionar declarações para método ProdutoDAOTest.AdicionarTest(ProdutoDAO, Produto)
        }

        /// <summary>Stub de teste para Excluir(Produto)</summary>
        [PexMethod]
        internal int ExcluirTest([PexAssumeUnderTest]ProdutoDAO target, Produto produto)
        {
            int result = target.Excluir(produto);
            return result;
            // TODO: adicionar declarações para método ProdutoDAOTest.ExcluirTest(ProdutoDAO, Produto)
        }

        /// <summary>Stub de teste para ListaProduto()</summary>
        [PexMethod]
        internal List<Produto> ListaProdutoTest([PexAssumeUnderTest]ProdutoDAO target)
        {
            List<Produto> result = target.ListaProduto();
            return result;
            // TODO: adicionar declarações para método ProdutoDAOTest.ListaProdutoTest(ProdutoDAO)
        }
    }
}
