namespace MVCRockets.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVCRockets.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCRockets.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCRockets.Models.ApplicationDbContext";
        }

        protected override void Seed(MVCRockets.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if(!context.Users.Any(u => u.UserName == "admin@myBandSite.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@myBandSite.com",
                    Email = "admin@myBandSite.com"
                };

                IdentityResult result = userManager.Create(user, "Password12#");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");
                context.SaveChanges();

                //Run - update-database -verbose in the PMC
                //After this will create an Admin Role in the App_Data/aspnet-MVCRockets-20190612103505.mdf under AspNetRoles table
            }
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
