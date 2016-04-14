using Strategy.Pattern;

namespace Strategy.Business
{
    public class ContextoStrategyDesconto
    {
        private readonly IDescontoStrategy _descontoStrategy;
        public ContextoStrategyDesconto(IDescontoStrategy descontoStrategy)
        {
            _descontoStrategy = descontoStrategy;
        }

        public decimal Calcular(decimal valor_)
        {
            return _descontoStrategy.CalculaDesconto(valor_);
        }
    }
}