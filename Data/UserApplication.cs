using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Negociantes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Negociantes.Data
{
    public class UserApplication :  IdentityDbContext<User>
    {
        public UserApplication(DbContextOptions<UserApplication> options) : base(options)
        {
        }
    }
}
