using Rainbow.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Claims;

namespace Rainbow.Data.DBContext
{
    public static class DatabaseInitializer
    {
        public static void Init(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetService<UserManager<User>>();

            var user = new User()
            {
                Email = "admin@gmail.com",
                Name = "admin",
                Surname = "admin",
                UserName = "admin"
            };

            var result = userManager.CreateAsync(user, "admin").GetAwaiter().GetResult();
            if (result.Succeeded)
                userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Administrator")).GetAwaiter().GetResult();
        }
    }
}
