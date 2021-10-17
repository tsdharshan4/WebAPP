using LogisticsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsDemo.Infrastructure
{
        public class Context : DbContext
        {
            public Context(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Cities> cities { get; set; }
        }
    
}
