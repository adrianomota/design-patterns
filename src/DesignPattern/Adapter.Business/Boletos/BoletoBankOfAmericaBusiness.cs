using Adapter.Business.Base;
using Adapter.Model;
using BankOfAmerica;

namespace Adapter.Business
{
    //classe adaptadora
    public sealed class BoletoBankOfAmericaBusiness:IBoleto
    {
        //instanciando o boleto de terceiro
        private BilletBankOfAmerica _boletoBankOfAmerica = new BilletBankOfAmerica();

        public void EmitirBoleto(Boleto boleto_)
        {
            _boletoBankOfAmerica.TransmitBillet(boleto_.valor);
        }
    }
}