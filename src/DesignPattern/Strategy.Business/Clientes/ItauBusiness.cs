using System;
using Strategy.Model.Model;
using Strategy.Pattern;

namespace Strategy.Business
{
    public sealed class ItauBusiness:IValidacaoStrategy
    {
        public void ValidarCamposObrigatorios(Cliente cliente)
        {
            if (String.IsNullOrWhiteSpace(cliente.Nome))
                throw new ApplicationException("O campo nome deve ser preenchido");

            if (cliente.Nome.StartsWith("Itau"))
                throw new ApplicationException("O campo nome deve começar com Itau");
        }
    }
}