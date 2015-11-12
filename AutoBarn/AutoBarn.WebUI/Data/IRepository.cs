using System.Linq;

namespace AutoBarn.WebUI.Data
{
    public interface IRepository<T>
    {
        T Find(int id);
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        void Commit();
    }
}