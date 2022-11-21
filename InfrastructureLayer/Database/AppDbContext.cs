using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfrastructureLayer
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions dboptions) : base(dboptions)
        {
        }
        public DbSet<UserVerify> VerifyDetails { get; set; }

    }


}
