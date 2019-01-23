using CustomerCloud.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Repository
{
    public class Repository<T> where T : class, IEntity
    {
        private CustomerContext _context;

        public Repository()
        {
            _context = new CustomerContext();
        }

        public void Create(T item)
        {
            _context.Entry<T>(item).State = EntityState.Added;
            _context.SaveChangesAsync();
        }

        public T Read(Guid Id)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            return dbQuery.FirstOrDefault(i => i.Id == Id);
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void Delete(T item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChangesAsync();
        }

    }
}
