using System;
using Microsoft.AspNetCore.Identity;

namespace MyFilmMVCV1
{

    public class AppIdentityRole : IdentityRole
    {
        public string RoleDescription { get; set; }
    }


}
