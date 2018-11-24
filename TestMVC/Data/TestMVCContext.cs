using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestMVC.Models;

namespace TestMVC.Models
{
    public class TestMVCContext : DbContext
    {
        public TestMVCContext (DbContextOptions<TestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TestMVC.Models.Product> Product { get; set; }

        public DbSet<TestMVC.Models.Category> Category { get; set; }
    }
}
