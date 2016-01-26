
using NUnit.Framework;
using Strategy.Business;
using Strategy.Model.Model;

namespace Strategy.Test
{
    [TestFixture]
    public sealed class DescontoTest
    {
        [Test]
        public void Testar_Desconto_Do_Produto_No_Natal()
        {
            var produtoNatal = new Produto(1,"Livro Design Pattern","Livro sobre Padrões de Projeto",100m);            
            var contexto =  new ContextoStrategyDesconto(new NatalBusiness());
            var valorDesconto = contexto.Calcular(produtoNatal.Valor);

            produtoNatal.SetValor(valorDesconto);

            Assert.AreEqual(90,produtoNatal.Valor);
        }

        public void Testar_Desconto_Do_Produto_No_BlackFriday()
        {

        }
    }
}