using System;
using System.Linq;
using ActiveRecord.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActiveRecord.Test
{
    [TestClass]
    public class ContatoTest
    {
        [TestMethod]
        public void InseriContatoTest()
        {
            //arrange
            var contato = new Contato("Contato ActiveRecord 2","contato@contato.com.br","01122223333",DateTime.Now);
            contato.AssociarEstadoCivil(1);
            contato.AssociarSexo(1);

            //action
            contato.Cadastrar();

            var contatoCadastrado = contato.Pesquisar(c=>c.Nome == contato.Nome).FirstOrDefault();

            //assert
            Assert.IsNotNull(contatoCadastrado);
            Assert.AreEqual(contatoCadastrado.Nome,contato.Nome);
        }
    }
}
