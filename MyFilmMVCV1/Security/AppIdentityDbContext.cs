using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyFilmMVCV1
{

    public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppIdentityDbContext
            (DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }
    }

}
