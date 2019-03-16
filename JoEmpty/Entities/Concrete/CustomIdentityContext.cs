using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CustomIdentityContext : IdentityDbContext<User,IdentityRole<Guid>,Guid>
    {
        public CustomIdentityContext(DbContextOptions options) : base(options)
        {
        }
    }
}
