using System;

namespace Adapter.Model
{
    public sealed class Pagamento
    {
        public Pagamento(string login_, string senha_, decimal valor_)
        {
            Id = Guid.NewGuid();
            Login = login_;
            Senha = senha_;
            Valor = valor_;
        }
        public Guid Id { get; private set; }
        public decimal Valor { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}