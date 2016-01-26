using System;

namespace Adapter.Model
{
    public sealed class Boleto
    {
        public Boleto()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public decimal valor { get; set; }

        public DateTime DataVencimento { get; set; }

        public string Cedente  { get; set; }

        public string Sacado  { get; set; }
    }
}