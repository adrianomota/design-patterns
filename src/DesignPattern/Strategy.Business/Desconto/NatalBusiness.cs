using Strategy.Pattern;

namespace Strategy.Business
{
    public sealed class NatalBusiness : IDescontoStrategy
    {
        public decimal CalculaDesconto(decimal valor)
        {
            return (valor * 20) / 100;
        }
    }
}