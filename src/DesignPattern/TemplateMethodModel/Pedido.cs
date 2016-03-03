using System;

namespace TemplateMethodModel
{
    public sealed class Pedido
    {
        public Pedido(string nome)
        {
            Codigo = Guid.NewGuid();
            Nome = nome;
        }
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal ValorTotal { get; set; }
    }
}