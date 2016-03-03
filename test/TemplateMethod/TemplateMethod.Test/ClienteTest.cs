using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateMethod.Business;
using TemplateMethodModel;

namespace TemplateMethod.Test
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void TestarClienteSemTemplate()
        {
            var novoCliente = new Cliente("Cliente 1");
         
            //var clieteBusiness = new ClienteBusiness();
            //if(clieteBusiness.ValidarCamposObrigatorios(novoCliente))
            //   clieteBusiness.Cadastrar(novoCliente);
        }

        [TestMethod]
        public void TestarClienteComTemplate()
        {
            var novoCliente = new Cliente("Cliente 1");

            var clieteBusiness = new ClienteBusiness();

            clieteBusiness.Execucao(novoCliente);
        }
    }
}