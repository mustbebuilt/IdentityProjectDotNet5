using System;
using Microsoft.AspNetCore.Identity;

namespace CRUDFilmDbProject.Security
{
    public class AppIdentityUser :IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
