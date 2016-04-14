using System;

namespace Strategy.Pattern
{
    public interface IDescontoStrategy
    {
        Decimal CalculaDesconto(Decimal valor);
    }
}