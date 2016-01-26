using Adapter.Model;

namespace Adapter.Business.Base
{
    public interface IBoleto
    {
        void EmitirBoleto(Boleto boleto_);
    }
}