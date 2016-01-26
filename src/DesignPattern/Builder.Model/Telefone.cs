using System;

namespace Builder.Model
{
    public sealed class Telefone
    {
        public Guid Id { get; set; }
        public string DDD { get; set; }

        public string Numero { get; set; }

        public string Operadora { get; set; }
    }
}