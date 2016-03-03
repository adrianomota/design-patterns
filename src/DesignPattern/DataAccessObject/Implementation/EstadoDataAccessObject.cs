using System.Collections.Generic;
using System.Linq;
using DataAccessObject.Base;
using DataAccessObject.Model;

namespace DataAccessObject.Implementation
{
    public sealed class EstadoDataAccessObject:ILeituraDataAccessObject<EstadoCivil>
    {
        private readonly ConnectionContext _context;

        public EstadoDataAccessObject()
        {
            _context = new ConnectionContext();
        }
        public IEnumerable<EstadoCivil> GetAll()
        {
            return _context.EstadoCivil.ToList();
        }
    }
}