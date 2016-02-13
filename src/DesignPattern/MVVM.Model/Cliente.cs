using System;

namespace MVVM.Model
{
    public sealed class Cliente
    {
        public Cliente(string nome_,string email_, string telefone_, DateTime? dataNascimento_)
        {
            Id = Guid.NewGuid();
            Nome = nome_;
            Telefone = telefone_;
            DataNascimento = dataNascimento_;
            Email = email_;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; private set; }

        public void AlterarNome(string nome_)
        {
            Nome = nome_;
        }

        public void AlterarTelefone(string telefone_)
        {
            Telefone = telefone_;
        }

        public void AlterarEmail(string email_)
        {
            Email = email_;
        }
        public void AlterarDataNascimento(DateTime dataNascimento_)
        {
            DataNascimento = dataNascimento_;
        }
    }
}