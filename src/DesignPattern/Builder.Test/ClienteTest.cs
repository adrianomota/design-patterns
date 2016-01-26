using Builder.Model.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Builder.Test
{
    [TestClass]
    public sealed class ClienteTest
    {
        [TestMethod]
        public void Testar_Padrao_Builder_Uma_Chamada()
        {
            var builderCliente = new ClienteBuilder();

            //arrange

            //etapa 1
            builderCliente.SetarDadosPessoais("Zina", "zina@outlook.com", DateTime.Now);

            //etapa 2
            builderCliente.SetarEndereco("Rua Tuiti", "123", "0654098");

            //etapa 3
            builderCliente.SetarFoto(@"c:\fotos", "foto1", "png");

            //action
            var cliente = builderCliente.Gerar();

            //assert
            Assert.IsNotNull(cliente);
            Assert.AreEqual("Zina", cliente.Nome);
            Assert.AreEqual("zina@outlook.com", cliente.Email);
            Assert.AreEqual(DateTime.Now.ToShortDateString(),cliente.DataNascimento.ToShortDateString());
        }

        [TestMethod]
        public void Testar_Padrao_Builder_Modo_Recursivo()
        {
            //arrange
            var builderCliente = new ClienteBuilder();

            //modo ONP
            var cliente = builderCliente.SetarDadosPessoais("Zina", "zina@outlook.com", DateTime.Now)
                                        .SetarEndereco("Rua Tuiti", "123", "0654098")
                                        .SetarFoto(@"c:\fotos", "foto1", "png")
                                        .Gerar();

            //assert
            Assert.IsNotNull(cliente);
            Assert.AreEqual("Zina", cliente.Nome);
            Assert.AreEqual("zina@outlook.com", cliente.Email);
            Assert.AreEqual(DateTime.Now.ToShortDateString(), cliente.DataNascimento.ToShortDateString());
        }
    }
}