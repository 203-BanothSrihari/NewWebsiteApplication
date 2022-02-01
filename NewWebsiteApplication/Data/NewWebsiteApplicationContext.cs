using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewWebsiteApplication.Models;

namespace NewWebsiteApplication.Data
{
    public class NewWebsiteApplicationContext : DbContext
    {
        public NewWebsiteApplicationContext (DbContextOptions<NewWebsiteApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<NewWebsiteApplication.Models.Product> Product { get; set; }
    }
}
