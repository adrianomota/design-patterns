using Strategy.Pattern;

namespace Strategy.Business
{
    public sealed class DiaDasMaesBusiness:IDescontoStrategy
    {
        public decimal CalculaDesconto(decimal valor)
        {
            return (valor * 10) / 100;
        }
    }
}