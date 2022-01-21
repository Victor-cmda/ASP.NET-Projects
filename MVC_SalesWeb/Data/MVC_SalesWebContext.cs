using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_SalesWeb.Models;

namespace MVC_SalesWeb.Data
{
    public class MVC_SalesWebContext : DbContext
    {
        public MVC_SalesWebContext (DbContextOptions<MVC_SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_SalesWeb.Models.Department> Department { get; set; }
    }
}
