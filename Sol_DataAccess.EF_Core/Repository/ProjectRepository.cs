using Sol_DataAccess.EF_Core.ApplicationDbContext;
using Sol_Domain.Entities;
using Sol_Domain.Interface;

namespace Sol_DataAccess.EF_Core.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
