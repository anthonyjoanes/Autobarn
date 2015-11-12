using System.Data.Entity;
using System.Linq;

namespace AutoBarn.WebUI.Data
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _set;

        public SqlRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public T Find(int id)
        {
            return _set.Find(id);
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _set;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}