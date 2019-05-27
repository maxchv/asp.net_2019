using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace lesson17.Models
{
    public class DbContextDemo: DbContext
    {
        public DbSet<Data> Datas { get; set; }

        public DbContextDemo(IConfiguration conf)
        {
            Configuration = conf;
        }

        public IConfiguration Configuration { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }

    public class Data
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
