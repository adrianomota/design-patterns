using NullObject.Business.Base;

namespace NullObject.Business
{
    public sealed class DescontoNullObjectBusiness:IBaseBusiness
    {
        public decimal CalcularDesconto(decimal valorProduto)
        {
            return valorProduto;
        }
    }
}