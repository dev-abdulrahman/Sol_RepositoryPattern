using Sol_Domain.Entities;

namespace Sol_Domain.Interface
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
