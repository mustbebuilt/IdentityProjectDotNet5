using System;
using Microsoft.AspNetCore.Identity;

namespace MyFilmMVCV1
{
    public class AppIdentityUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
