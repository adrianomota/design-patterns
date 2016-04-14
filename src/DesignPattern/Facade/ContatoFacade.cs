using Common;
using Facade.Business;
using Facade.Model.Model;

namespace Facade
{
    public sealed class ContatoFacade
    {
        public void IniciarProcessamento(ContatoModel contato)
        {
            //action
            var negocioContato = new ContatoBusiness();
            negocioContato.ValidarCamposObrigatorios(contato);

            EmailHelper.Enviar("aula.padroes@gmail.com",
                                "adrianowsh@hotmail.com",
                                "Contato cadastrado com sucesso",
                                "O contato foi aducionado");

            ArquivoHelper.GravarLog("Contato cadastrado");

            //assertion   
        }
    }
}