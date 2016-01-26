using Adapter.Business.Base;
using Adapter.Model;
using JPMorgan;

namespace Adapter.Business
{
    public sealed class BoletoJpMorganBusiness:IBoleto
    {
        //instanciando a dll de terceiro
        private BilletJPMorgan _boletoJpMorgan = new BilletJPMorgan();
        public void EmitirBoleto(Boleto boleto_)
        {
            _boletoJpMorgan.SendBillet(boleto_.valor);
        }
    }
}