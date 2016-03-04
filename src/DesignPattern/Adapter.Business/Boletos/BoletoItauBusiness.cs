using Adapter.Business.Base;
using Adapter.Model;
using System;

namespace Adapter.Business
{
    public class BoletoItauBusiness : IBoleto
    {
        public void EmitirBoleto(Boleto boleto_)
        {
            if (string.IsNullOrWhiteSpace(boleto_.Cedente))
                throw new ApplicationException("Informe o cedente");

            if (string.IsNullOrWhiteSpace(boleto_.Sacado))
                throw new ApplicationException("Informe o sacado");

            if (boleto_.Valor <= 0)
                throw new ApplicationException("Valor inválido!");


#warning "Acionando um webservice de terceiro"

        }
    }
}