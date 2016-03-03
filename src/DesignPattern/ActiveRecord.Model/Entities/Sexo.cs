using System;
using System.Collections.Generic;
using System.Runtime;

namespace ActiveRecord.Model
{
    public sealed class Sexo:IBaseModel<Sexo>
    {
        #region Properties
        public Int32 Codigo { get; set; }
        public String Descricao { get; set; }
        #endregion

        #region Methods
        public IEnumerable<Sexo> Listar()
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
        #endregion
    }
}