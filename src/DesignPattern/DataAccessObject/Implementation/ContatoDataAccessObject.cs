using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessObject.Interfaces;
using DataAccessObject.Model;

namespace DataAccessObject.Implementation
{
    public sealed class ContatoDataAccessObject:IContatoDataAccessObject<Contato>
    {
        private readonly ConnectionContext _context;

        public ContatoDataAccessObject()
        {
            _context = new ConnectionContext();
        }
        public void Add(Contato obj)
        {
            _context.Contato.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Contato obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(Contato obj)
        {
            _context.Contato.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Contato> GetAll()
        {
            return _context.Contato.ToList();
        }

        public IEnumerable<Contato> Search(Expression<Func<Contato, bool>> predicate)
        {
            return _context.Contato.Where(predicate);
        }
    }
}