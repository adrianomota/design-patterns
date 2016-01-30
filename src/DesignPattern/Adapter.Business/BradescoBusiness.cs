using System.Diagnostics;
using Adapter.Business.Base;
using Adapter.Model;

namespace Adapter.Business
{
    public sealed class BradescoBusiness:IBoleto
    {
        public void EmitirBoleto(Boleto boleto_)
        {
            Debug.WriteLine("Emitindo boleto no bradesco...");
        }
    }
}