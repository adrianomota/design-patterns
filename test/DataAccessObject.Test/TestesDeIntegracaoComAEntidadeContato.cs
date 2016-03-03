using System;
using System.Linq;
using DataAccessObject.Implementation;
using DataAccessObject.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccessObject.Test
{
    [TestClass]
    public class TestesDeIntegracaoComAEntidadeContato
    {
        private ContatoDataAccessObject _contatoDAO;

        [TestMethod]
        public void Excluir_Contato_Test()
        {
            //arrange


            //action


            //assert
        }

        [TestMethod]
        public void Seleciona_Contato_Test()
        {
            //arrange


            //action


            //assert
        }

        [TestMethod]
        public void Inseri_Contato_Test()
        {
            //arrange
            var _contatoDAO = new ContatoDataAccessObject();
            var novoContato = new Contato("Contato 4","contato@gmail.com","01122223333",DateTime.Now);
            novoContato.AssociarEstadoCivil(1);
            novoContato.AssociarSexo(1);

            //action
            _contatoDAO.Add(novoContato);
            var retContato = _contatoDAO.Search(c => c.Nome.StartsWith(novoContato.Nome)).Single();

            //assert
            Assert.IsNotNull(retContato);
            Assert.AreEqual(novoContato.Nome,retContato.Nome);
        }

        [TestMethod]
        public void Atualizar_Contato_Test()
        {
            //arrange
            var _contatoDAO = new ContatoDataAccessObject();
            var contatoModificado = _contatoDAO.Search(c => c.Nome.StartsWith("Contato 4")).Single();

            //action
            contatoModificado.AlterarTelefone("01122225555");
            contatoModificado.AlterarEmail("contato4@gmail.com.br");
            contatoModificado.AlterarNome("Contato 4 atualizado");

            //action
            _contatoDAO.Update(contatoModificado);
            var ret = _contatoDAO.Search(c => c.Nome.StartsWith("Contato atualizado")).Single();

            //assert
            Assert.AreEqual(ret.Telefone,contatoModificado.Telefone);
            Assert.AreEqual(ret.Nome, contatoModificado.Nome);
        }
    }
}
