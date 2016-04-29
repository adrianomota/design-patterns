using System;

namespace NullObject.DataTransferObject
{
    public sealed class ProdutoDTO
    {
        public ProdutoDTO(string nome,decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        public string AlterarNome(string nome)
        {
            Nome = nome;
            return Nome;
        }

        public decimal AlterarValor(decimal valor)
        {
            Valor = valor;
            return Valor;
        }
    }
}