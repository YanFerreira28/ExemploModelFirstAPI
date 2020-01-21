using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ModelAPI.Contracts;
using ModelAPI.Data;

namespace ModelAPI.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public modelFirstEntities _context;

        public RepositoryBase(modelFirstEntities context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(x);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            _context.Entry(obj).State = EntityState.Added;
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}