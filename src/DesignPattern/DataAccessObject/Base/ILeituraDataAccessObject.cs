using System.Collections.Generic;

namespace DataAccessObject.Base
{
    public interface ILeituraDataAccessObject<T>
    {
        IEnumerable<T> GetAll();
    }
}