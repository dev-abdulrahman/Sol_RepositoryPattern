using Microsoft.EntityFrameworkCore;
using Sol_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_DataAccess.EF_Core.ApplicationDbContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }

        public DbSet<Developer> Developer { get; set; }
        public DbSet<Project> Project { get; set; }
    }
}
