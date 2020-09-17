using Microsoft.AspNetCore.Identity;
using System;

namespace Rainbow.Core.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
        }
        public User(string username) : base(username)
        {
        }    

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
