using System.Diagnostics;
using Adapter.Business.Base;
using Adapter.Model;

namespace Adapter.Business
{
    public sealed class ItauBusiness:IBoleto
    {
        public void EmitirBoleto(Boleto boleto_)
        {
           Debug.WriteLine("Emitinfo boleto no itau...");
        }
    }
}