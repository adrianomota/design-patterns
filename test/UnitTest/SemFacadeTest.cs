using Common;
using Facade.Business;
using Facade.Model.Model;
using NUnit.Framework;

namespace Facade.UnitTest
{
    [TestFixture]
    public sealed class SemFacadeTest
    {
        [Test]
        public void Testar_Camadas_Sem_Padrao_Facade()
        {
            //arrange
            var novoContato = new ContatoModel();
            novoContato.Nome = "Adriano Mota";
            novoContato.Email = "adrianowsh@hotmail.com";

            //action
            var negocioContato = new ContatoBusiness();
            negocioContato.ValidarCamposObrigatorios(novoContato);

            EmailHelper.Enviar("aula.padroes@gmail.com",
                                "adrianowsh@hotmail.com",
                                "Contato cadastrado com sucesso",
                                "O contato foi aducionado");

            ArquivoHelper.GravarLog("Contato cadastrado");
            //assertion
        }
    }
}