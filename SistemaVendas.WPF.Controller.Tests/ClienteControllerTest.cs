// <copyright file="ClienteControllerTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas.WPF.Controller;
using SistemaVendas.WPF.Models;

namespace SistemaVendas.WPF.Controller.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ClienteController</summary>
    [PexClass(typeof(ClienteController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClienteControllerTest
    {
        /// <summary>Stub de teste para .ctor()</summary>
        [PexMethod]
        public ClienteController ConstructorTest()
        {
            ClienteController target = new ClienteController();
            return target;
            // TODO: adicionar declarações para método ClienteControllerTest.ConstructorTest()
        }

        /// <summary>Stub de teste para ListarPeloID(Int32)</summary>
        [PexMethod]
        public Cliente ListarPeloIDTest([PexAssumeUnderTest]ClienteController target, int id)
        {
            Cliente result = target.ListarPeloID(id);
            return result;
            // TODO: adicionar declarações para método ClienteControllerTest.ListarPeloIDTest(ClienteController, Int32)
        }

        /// <summary>Stub de teste para Listar()</summary>
        [PexMethod]
        public List<Cliente> ListarTest([PexAssumeUnderTest]ClienteController target)
        {
            List<Cliente> result = target.Listar();
            return result;
            // TODO: adicionar declarações para método ClienteControllerTest.ListarTest(ClienteController)
        }

        /// <summary>Stub de teste para Remover(Cliente)</summary>
        [PexMethod]
        public bool RemoverTest([PexAssumeUnderTest]ClienteController target, Cliente cliente)
        {
            bool result = target.Remover(cliente);
            return result;
            // TODO: adicionar declarações para método ClienteControllerTest.RemoverTest(ClienteController, Cliente)
        }

        /// <summary>Stub de teste para Salvar(Cliente)</summary>
        [PexMethod]
        public void SalvarTest([PexAssumeUnderTest]ClienteController target, Cliente cliente)
        {
            target.Salvar(cliente);
            // TODO: adicionar declarações para método ClienteControllerTest.SalvarTest(ClienteController, Cliente)
        }
    }
}
