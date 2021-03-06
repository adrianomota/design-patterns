﻿using System;
using Adapter.Business.Base;

namespace Adapter.Business
{
    public class MasterCardBusiness:IAdministradora
    {
        private const decimal VALOR_MINIMO_PAGAMENTO = 10;
        public void Pagar(Model.Pagamento pagamento_)
        {
            if (string.IsNullOrWhiteSpace(pagamento_.Login))
                throw new ApplicationException("Informe o login");

            if (string.IsNullOrWhiteSpace(pagamento_.Senha))
                throw new ApplicationException("Informe o senha");

            if(pagamento_.Valor < VALOR_MINIMO_PAGAMENTO)
                throw new ApplicationException("Valor minimo desta operação é acima de " + VALOR_MINIMO_PAGAMENTO);
        }
    }
}