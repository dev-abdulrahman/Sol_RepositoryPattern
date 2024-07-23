using Microsoft.EntityFrameworkCore;
using Sol_DataAccess.EF_Core.ApplicationDbContext;
using Sol_Domain.Interface;

namespace Sol_DataAccess.EF_Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext applicationContext;

        public GenericRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task Add(T entity)
        {
            await this.applicationContext.Set<T>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await this.applicationContext.Set<T>().AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return this.applicationContext.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return this.applicationContext.Set<T>().AsNoTracking();
        }

        public async Task<T?> GetById(int id)
        {
            return await this.applicationContext.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            this.applicationContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            this.applicationContext.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            this.applicationContext.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            this.applicationContext.UpdateRange(entities);
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            this.applicationContext.Set<T>().Remove(entity);
        }
    }
}
