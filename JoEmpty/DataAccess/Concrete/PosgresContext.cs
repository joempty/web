using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class PosgresContext : IdentityDbContext<User>
    {
        public PosgresContext(DbContextOptions options) : base(options)
        {
        }
    }
}
