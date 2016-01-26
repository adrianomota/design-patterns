using System;

namespace Adapter.Model
{
    public sealed class Pagamento
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }
    }
}