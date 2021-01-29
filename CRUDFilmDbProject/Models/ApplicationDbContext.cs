using System;
using Microsoft.EntityFrameworkCore;

namespace CRUDFilmDbProject.Models
{
    public class ApplicationDbContext: DbContext
    {

         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

        public DbSet<Film> Films { get; set; }
    }
}
