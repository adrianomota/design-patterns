using NullObject.Business.Base;

namespace NullObject.Business
{
    public sealed class DescontoNamoradosBusiness:IBaseBusiness
    {
        public decimal CalcularDesconto(decimal valorProduto)
        {
            return valorProduto + 100;
        }
    }
}