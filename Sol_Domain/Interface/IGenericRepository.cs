using System.Linq.Expressions;

namespace Sol_Domain.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        Task Delete(int id);


    }
}
