using System;
using System.Collections.Generic;

namespace ActiveRecord.Model
{
    public sealed class EstadoCivil:EntityBase,IBaseModel<EstadoCivil>
    {
       
        public string Descricao { get; set; }

        public IEnumerable<EstadoCivil> Listar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }
    }
}