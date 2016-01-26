using System;

namespace Builder.Model
{
    public sealed class Foto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string Extensao { get; set; }
    }
}