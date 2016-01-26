using NUnit.Framework;
using Strategy.Business;
using Strategy.Business.Validacao;
using Strategy.Model.Model;

namespace Strategy.Test
{
    //Existem duas formas de acionar dlls
    //EARLING BINDING (add reference) e LATE BINDING (dinamicamente - reflection)

    [TestFixture]
    public sealed class ValidacaoTest
    {
        [Test]
        public void TestarRegrasDeValidacaoDoItauComStrategy()
        {
            //arrange
            var clienteItau = new Cliente(1, "ItauCliente 1", "1234", "01199993333");

            var contrato = new ContextoStrategyCliente(new ItauBusiness());

            //Action
            contrato.ValidarRegras(clienteItau);


            //Assert



        }

        [Test]
        public void TestarRegrasDeValidacaoDoBradescoComStrategy()
        {
            
            //Arrange

            var clienteBradesco = new Cliente(1, "BraCliente 1", "1234", "01199993333");

            var contrato = new ContextoStrategyCliente(new ItauBusiness());

            //Action
            contrato.ValidarRegras(clienteBradesco);


            //Assert

        }
    }
}