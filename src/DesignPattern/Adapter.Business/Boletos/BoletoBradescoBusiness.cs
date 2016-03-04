using System;
using Adapter.Business.Base;
using Adapter.Model;

namespace Adapter.Business
{
    public class BoletoBradescoBusiness:IBoleto
    {
        // existe um termo chamado CODE SMELLS (codigo mal feito)
        // numeros mágicos perdidos no código é um exemplo
        // criar constantes ou enum é uma boa prática para nomear

        public void EmitirBoleto(Boleto boleto_)
        {
            const Decimal VALOR_MAXIMO_BOLETO =15000;

            if (string.IsNullOrWhiteSpace(boleto_.Cedente))
                throw new ApplicationException("Informe o cedente");

            if (string.IsNullOrWhiteSpace(boleto_.Sacado))
                throw new ApplicationException("Informe o sacado");

            if (boleto_.Valor >= VALOR_MAXIMO_BOLETO)
                throw new ApplicationException("Valor máximo excedido!!");
            
            
            //acionando webservice de terceiro
        }
    }
}