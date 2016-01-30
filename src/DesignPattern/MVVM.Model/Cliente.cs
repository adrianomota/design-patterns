using System;

namespace MVVM.Model
{
    public class Cliente
    {
        public Cliente(string nome, string telefone, DateTime dataNascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public void AlterarDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
    }
}