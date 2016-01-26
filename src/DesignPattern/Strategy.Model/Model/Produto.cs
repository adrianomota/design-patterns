namespace Strategy.Model.Model
{
    public sealed class Produto : Base
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public Produto(int id, string nome, string descricao,decimal valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
        }

        public void SetValor(decimal valor)
        {
            this.Valor = valor;
        }
    }
}