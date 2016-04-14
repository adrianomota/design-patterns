using Facade.Model.Model;
using System;

namespace Facade.Business
{
    public sealed class ContatoBusiness
    {
        //Temos que validar algumas validações da classe de contato

        public void ValidarCamposObrigatorios(ContatoModel contato_)
        {
            if (string.IsNullOrWhiteSpace(contato_.Nome))
                throw new ApplicationException("Informe o nome!");

            if (string.IsNullOrWhiteSpace(contato_.Email))
                throw new ApplicationException("Informe o e-mail!");
        }
    }
}