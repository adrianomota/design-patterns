using System.Collections.Generic;
using IoC.DataTransferObject;

namespace IoC.DAO.Base
{
    public interface IBaseDAO<DTO> where DTO : class
    {
        IEnumerable<DTO> Listar();

        void Cadastrar(AmigoDTO registro_);
    }
}