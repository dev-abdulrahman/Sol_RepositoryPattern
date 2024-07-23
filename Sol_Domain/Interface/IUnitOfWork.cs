using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }
        Task<int> SaveChanges();
    }
}
