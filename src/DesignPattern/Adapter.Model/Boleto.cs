using System;

namespace Adapter.Model
{
    public sealed class Boleto
    {
        public Boleto(string cedente_,string sacado_,decimal valor_,DateTime dataVencimento_)
        {
            Id = Guid.NewGuid();
            Cedente = cedente_;
            Sacado = sacado_;
            Valor = valor_;
            DataVencimento = dataVencimento_;
        }
        public Guid Id { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataVencimento { get; private set; }

        public string Cedente  { get; private set; }

        public string Sacado  { get; private set; }
    }
}