using Facade;
using Facade.Model.Model;
using NUnit.Framework;

namespace Facade.UnitTest
{
    [TestFixture]
    public sealed class ComFacadeTest
    {
        [Test]
        public void Testar_camada_com_facade_fechada()
        {
            //arrange
            var novoContato = new ContatoModel();
            novoContato.Nome = "Adriano Mota";
            novoContato.Email = "adrianowsh@hotmail.com";

            //action
            var facadeContato = new ContatoFacade();
            facadeContato.IniciarProcessamento(novoContato);

            //assert
        }
    }
}