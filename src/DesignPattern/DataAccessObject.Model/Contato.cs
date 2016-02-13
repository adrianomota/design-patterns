using System;

namespace DataAccessObject.Model
{
    public sealed class Contato:Base
    {
        public Int32 CodigoSexo { get; set; }
        public Int32 CodigoEstadoCivil { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivil Estado { get; set; }
        public Sexo Sexo { get; set; }
    }
}