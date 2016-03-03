using System;

namespace TemplateMethodModel
{
    public sealed class Cliente
    {
        public Cliente(string nome)
        {
            Codigo = Guid.NewGuid();
            Nome = nome;
        }
        public Guid Codigo { get; private set; }
        public string Nome { get; private set; }

    }
}