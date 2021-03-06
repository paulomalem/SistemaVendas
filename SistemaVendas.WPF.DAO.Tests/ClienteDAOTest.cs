// <copyright file="ClienteDAOTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.DAO;
using SistemaVendas.WPF.Models;

namespace SistemaVendas.WPF.DAO.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ClienteDAO</summary>
    [PexClass(typeof(ClienteDAO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClienteDAOTest
    {
        /// <summary>Stub de teste para Adicionar(Cliente)</summary>
        [PexMethod]
        internal int AdicionarTest([PexAssumeUnderTest]ClienteDAO target, Cliente cliente)
        {
            int result = target.Adicionar(cliente);
            return result;
            // TODO: adicionar declarações para método ClienteDAOTest.AdicionarTest(ClienteDAO, Cliente)
        }

        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        internal ClienteDAO ConstructorTest()
        {
            ClienteDAO target = new ClienteDAO();
            return target;
            // TODO: adicionar declarações para método ClienteDAOTest.ConstructorTest()
        }

        /// <summary>Stub de teste para Excluir(Cliente)</summary>
        [PexMethod]
        internal int ExcluirTest([PexAssumeUnderTest]ClienteDAO target, Cliente cliente)
        {
            int result = target.Excluir(cliente);
            return result;
            // TODO: adicionar declarações para método ClienteDAOTest.ExcluirTest(ClienteDAO, Cliente)
        }

        /// <summary>Stub de teste para ListaClientePeloId(Int32)</summary>
        [PexMethod]
        internal Cliente ListaClientePeloIdTest([PexAssumeUnderTest]ClienteDAO target, int id)
        {
            Cliente result = target.ListaClientePeloId(id);
            return result;
            // TODO: adicionar declarações para método ClienteDAOTest.ListaClientePeloIdTest(ClienteDAO, Int32)
        }

        /// <summary>Stub de teste para ListaCliente()</summary>
        [PexMethod]
        internal List<Cliente> ListaClienteTest([PexAssumeUnderTest]ClienteDAO target)
        {
            List<Cliente> result = target.ListaCliente();
            return result;
            // TODO: adicionar declarações para método ClienteDAOTest.ListaClienteTest(ClienteDAO)
        }
    }
}
