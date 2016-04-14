using Strategy.Pattern;

namespace Strategy.Business
{
    public sealed class BlackFridayBusiness:IDescontoStrategy
    {
        public decimal CalculaDesconto(decimal valor)
        {
            return ((valor * 2) * 20) / 100;
        }
    }
}