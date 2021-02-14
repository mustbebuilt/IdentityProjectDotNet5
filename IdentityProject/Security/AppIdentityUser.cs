using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Security
{
    public class AppIdentityUser :IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
