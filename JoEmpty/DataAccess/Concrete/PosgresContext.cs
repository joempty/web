using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class PosgresContext : DbContext
    {

        public DbSet<UserTask> userTasks { get; set; }

        private IConfiguration configuration;

        public PosgresContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration["ConnectionStrings:DbConnection"]);
        }
    }
}
