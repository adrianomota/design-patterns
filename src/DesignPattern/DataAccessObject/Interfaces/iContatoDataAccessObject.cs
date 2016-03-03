using DataAccessObject.Base;
using DataAccessObject.Model;

namespace DataAccessObject.Interfaces
{
    public interface IContatoDataAccessObject<T>:IGravacaoDataAccessObject<T>,
                                              ILeituraDataAccessObject<T>,
                                              IPesquisarDataAccessObject<T>
    {
         
    }
}