using Sol_DataAccess.EF_Core.ApplicationDbContext;
using Sol_Domain.Interface;

namespace Sol_DataAccess.EF_Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private IDeveloperRepository _developerRepository;
        private IProjectRepository _projectRepository;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }
        public IDeveloperRepository Developers 
        {
            get
            {
                if(_developerRepository == null)
                {
                    _developerRepository = new DeveloperRepository(_context);
                }
                return _developerRepository;
            }
        }
        public IProjectRepository Projects 
        { 
            get
            {
                if(_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }
                return _projectRepository;
            }
        }

        public async Task<int> SaveChanges()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
