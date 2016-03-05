namespace RequestResponse.DataTransferObject
{
    public sealed class ClienteDTO:Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}