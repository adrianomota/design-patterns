using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullObject.Business;
using NullObject.Business.Base;
using NullObject.DataTransferObject;

namespace NullObject.Test
{
    [TestClass]
    public class DescontoTest
    {
        [TestMethod]
        public void TestarProduto()
        {
            //arrange
            var novoProduto = new ProdutoDTO("Celuar",1500);
            var dataAtual = new DateTime(2016,03,16);

            //action
            IBaseBusiness negocioProduto = null;
            
            if(dataAtual.ToString("ddMM") == "1203")
                negocioProduto = new DescontoNatalBusiness();
            else if (dataAtual.ToString("ddMM") == "1103")
                negocioProduto = new DescontoNamoradosBusiness();
            else
                negocioProduto = new DescontoNullObjectBusiness();
                
            
            //assert
            var novoValor = novoProduto.Valor;

            Assert.AreEqual(1500,novoValor);
        }
    }
}
