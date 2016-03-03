using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessObject.Base
{
    public interface IPesquisarDataAccessObject<T>
    {
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
    }
}