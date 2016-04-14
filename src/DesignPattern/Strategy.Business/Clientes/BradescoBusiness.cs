using Strategy.Model.Model;
using Strategy.Pattern;
using System;

namespace Strategy.Business
{
    public sealed class BradescoBusiness : IValidacaoStrategy
    {
        public void ValidarCamposObrigatorios(Cliente cliente)
        {
            if (String.IsNullOrWhiteSpace(cliente.Nome))
                throw new ApplicationException("O campo nome deve ser preenchido");

            if (cliente.Nome.StartsWith("Bra"))
                throw new ApplicationException("O campo nome deve começar com Bra");
        }
    }
}