using Strategy.Model.Model;
using Strategy.Pattern;

namespace Strategy.Business.Validacao
{
    public sealed class ContextoStrategyCliente
    {
        private readonly IValidacaoStrategy _strategyValidation;
        public ContextoStrategyCliente(IValidacaoStrategy strategyValidation_)
        {
            _strategyValidation = strategyValidation_;
        }


        public void ValidarRegras(Cliente cliente_)
        {
            _strategyValidation.ValidarCamposObrigatorios(cliente_);
        }
    }
}