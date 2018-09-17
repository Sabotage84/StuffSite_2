using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // создаем две роли
            var role1 = new IdentityRole { Name = "admin" };
            var role11 = new IdentityRole { Name = "moderator" };
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role11);
            roleManager.Create(role2);

            // создаем пользователей
            var admin = new ApplicationUser { Email = "root@mail.ru", UserName = "root@mail.ru" };
            string password = "qwZ_565656";
            var result = userManager.Create(admin, password);
            if (result.Succeeded)
                        {
                            // добавляем для пользователя роль
                            userManager.AddToRole(admin.Id, role1.Name);
                            userManager.AddToRole(admin.Id, role11.Name);
                            userManager.AddToRole(admin.Id, role2.Name);
                        }
            var moder = new ApplicationUser { Email = "moder@mail.ru", UserName = "moder@mail.ru" };
            
            var result2 = userManager.Create(moder, password);
            if (result2.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(moder.Id, role11.Name);
                userManager.AddToRole(moder.Id, role2.Name);
            }

            var testUser = new ApplicationUser { Email = "us@mail.ru", UserName = "us@mail.ru" };
            
            var result3 = userManager.Create(testUser, password);
            if (result3.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(moder.Id, role2.Name);
            }

            base.Seed(context);
        }

    }
}