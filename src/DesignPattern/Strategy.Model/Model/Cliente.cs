namespace Strategy.Model.Model
{
    public sealed class Cliente : Base
    {
        public string Nome { get; private set; }
        public string NumeroDocumento { get; private set; }
        public string NumeroTelefone { get; private set; }

        public Cliente(int id, string nome, string numeroDocumento, string numeroTelefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.NumeroDocumento = numeroDocumento;
            this.NumeroTelefone = numeroTelefone;
        }
    }
}