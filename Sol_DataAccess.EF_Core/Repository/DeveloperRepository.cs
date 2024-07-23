using Sol_DataAccess.EF_Core.ApplicationDbContext;
using Sol_Domain.Entities;
using Sol_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_DataAccess.EF_Core.Repository
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context): base(context)
        {
            
        }

        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return this.GetAll();
        }
    }
}
