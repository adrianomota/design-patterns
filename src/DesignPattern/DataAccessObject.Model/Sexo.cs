using System;

namespace DataAccessObject.Model
{
    public sealed class Sexo:Base
    {
        private  Sexo(){}

        public Sexo(string dscricao)
        {
            Descricao = Descricao;
        }
        public string Descricao { get; private set; }
    }
}
