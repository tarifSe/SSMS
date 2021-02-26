using Microsoft.EntityFrameworkCore;
using SSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSMS.DatabaseContext
{
    public class SSMSDbContext : DbContext
    {
        public SSMSDbContext(DbContextOptions<SSMSDbContext> options) : base(options)
        {

        }
       
        public DbSet<Category> Categories { get; set; }
    }
}
