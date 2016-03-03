using System;

namespace DataAccessObject.Model
{
    public sealed class EstadoCivil:Base
    {
        private  EstadoCivil(){}

        public EstadoCivil(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; private set; }
    }
}