using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObject.Business.Base;

namespace NullObject.Business
{
    public sealed class DescontoNatalBusiness:IBaseBusiness
    {
        public decimal CalcularDesconto(decimal valorProduto)
        {
            return valorProduto + 200;
        }
    }
}
