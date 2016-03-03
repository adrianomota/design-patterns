using System;
using TemplateMethodModel;

namespace TemplateMethod.Business
{
    public sealed class PedidoBusiness : BaseBusiness<Pedido>
    {
        protected override bool ValidarCamposObrigatorios(Pedido obj)
        {
            var retorno = true;

            retorno = !string.IsNullOrWhiteSpace(obj.Nome);
            
            retorno = obj.ValorTotal > 0;

            return retorno;
        }

        protected override void Cadastrar(Pedido obj)
        {
            throw new NotImplementedException();
        }
    }
}