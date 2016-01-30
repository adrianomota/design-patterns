using System;

namespace MVP.View.Model.Cliente
{
    public interface ICadastrarView
    {
        string Nome { get; set; }
        string Email { get; set; }
        string Telefone { get; set; }
        DateTime DataNascimento { get; set; }
        string Mensagem {set; }
    }
}