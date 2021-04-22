using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Negociantes.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }

        [DataType(DataType.Url)]
        public string Messenger { get; set; } //url validation 
        public string AvatarPath { get; set; }
    }
}
