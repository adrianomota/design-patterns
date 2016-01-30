using System;

namespace MVP.Model
{
    //Os 3 padroes visuais existentes são MVP, MVC e MVVM
    //MVC separa tela das reras de negócio.
    //MVP separa Tela, regras de negócio e campos da tela.
    //Model é um termo arquitetural que significa armazenar dados, regras de negócio e acesso a dados.

    public sealed class Cliente
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