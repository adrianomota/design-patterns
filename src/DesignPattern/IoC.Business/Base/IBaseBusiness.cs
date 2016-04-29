using System.Collections.Generic;

namespace IoC.Business.Base
{
    public interface IBaseBusiness<TDTO>
    {
        void Cadastrar(TDTO registro_);
        IEnumerable<TDTO> Listar();
    }
}