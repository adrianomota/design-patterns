using System.Collections.Generic;
using System.Linq;
using DataAccessObject.Base;
using DataAccessObject.Model;

namespace DataAccessObject.Implementation
{
    public sealed class SexoDataAccessObject:ILeituraDataAccessObject<Sexo>
    {
        private readonly ConnectionContext _context;

        public SexoDataAccessObject(ConnectionContext connectionContext)
        {
            _context = connectionContext;
        }


        public IEnumerable<Sexo> GetAll()
        {
            return _context.Sexo.ToList();
        }
    }
}