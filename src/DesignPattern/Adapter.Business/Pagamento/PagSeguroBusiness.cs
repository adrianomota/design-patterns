using Adapter.Business.Base;
using PagSeguro;

namespace Adapter.Business.Pagamento
{
    public class PagSeguroBusiness: PagSeguroPayment,IAdministradora
    {
        
        public void Pagar(Model.Pagamento pagamento_)
        {
            this.EfetuarPagamentoPagSeguro(pagamento_.Valor,pagamento_.Login,pagamento_.Senha);
        }
    }
}