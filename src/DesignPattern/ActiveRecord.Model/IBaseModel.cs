using System.Collections.Generic;

namespace ActiveRecord.Model
{
    public interface IBaseModel<T> where T: class
    {
        IEnumerable<T> Listar();
        void Cadastrar();
        void Atualizar();
        void Deletar();
    }
}