
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using projeto.Models;
using repositorioEF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace projeto
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<repositorioEF.DB, repositorioEF.Migrations.Configuration>());
            ApplicationDbContext db = new ApplicationDbContext();
            criaroles(db);
            criarsuperuser(db);
            AddPermissoesSuperUser(db);
            db.Dispose();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void AddPermissoesSuperUser(ApplicationDbContext db)
        {
            var usermaneger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = usermaneger.FindByName("leandroleanleo@gmail.com");
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));


            if (!usermaneger.IsInRole(user.Id, "Index"))
            {
                usermaneger.AddToRole(user.Id, "Index");
            }

            if (!usermaneger.IsInRole(user.Id, "Edit"))
            {
                usermaneger.AddToRole(user.Id, "Edit");
            }

            if (!usermaneger.IsInRole(user.Id, "EditCelula"))
            {
                usermaneger.AddToRole(user.Id, "EditCelula");
            }

            if (!usermaneger.IsInRole(user.Id, "Reuniao"))
            {
                usermaneger.AddToRole(user.Id, "Reuniao");
            }

            if (!usermaneger.IsInRole(user.Id, "Ministerio"))
            {
                usermaneger.AddToRole(user.Id, "Ministerio");
            }

            if (!usermaneger.IsInRole(user.Id, "Lider"))
            {
                usermaneger.AddToRole(user.Id, "Lider");
            }

            if (!usermaneger.IsInRole(user.Id, "Lider_treinamento"))
            {
                usermaneger.AddToRole(user.Id, "Lider_treinamento");
            }

            if (!usermaneger.IsInRole(user.Id, "Administrador"))
            {
                usermaneger.AddToRole(user.Id, "Administrador");
            }

            if (!usermaneger.IsInRole(user.Id, "Supervisor"))
            {
                usermaneger.AddToRole(user.Id, "Supervisor");
            }

            if (!usermaneger.IsInRole(user.Id, "Supervisor_treinamento"))
            {
                usermaneger.AddToRole(user.Id, "Supervisor_treinamento");
            }

            if (!usermaneger.IsInRole(user.Id, "Create"))
            {
                usermaneger.AddToRole(user.Id, "Create");
            }

            if (!usermaneger.IsInRole(user.Id, "Delete"))
            {
                usermaneger.AddToRole(user.Id, "Delete");
            }
        }

        private void criarsuperuser(ApplicationDbContext db)
        {
            var usermaneger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = usermaneger.FindByName("leandroleanleo@gmail.com");

            if(user == null)
            {
                user = new ApplicationUser
                {
                    UserName = "leandroleanleo@gmail.com",
                    Email = "leandroleanleo@gmail.com"
                };

                usermaneger.Create(user, "Manequim 1991");
            }

        }

        private void criaroles(ApplicationDbContext db)
        {
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));


            if (!rolemanager.RoleExists("Index"))
            {
                rolemanager.Create(new IdentityRole("Index"));
            }

            if (!rolemanager.RoleExists("Create"))
            {
                rolemanager.Create(new IdentityRole("Create"));
            }

            if (!rolemanager.RoleExists("Reuniao"))
            {
                rolemanager.Create(new IdentityRole("Reuniao"));
            }

            if (!rolemanager.RoleExists("Ministerio"))
            {
                rolemanager.Create(new IdentityRole("Ministerio"));
            }

            if (!rolemanager.RoleExists("Edit"))
            {
                rolemanager.Create(new IdentityRole("Edit"));
            }

            if (!rolemanager.RoleExists("EditCelula"))
            {
                rolemanager.Create(new IdentityRole("EditCelula"));
            }

            if (!rolemanager.RoleExists("Lider"))
            {
                rolemanager.Create(new IdentityRole("Lider"));
            }

            if (!rolemanager.RoleExists("Lider_treinamento"))
            {
                rolemanager.Create(new IdentityRole("Lider_treinamento"));
            }

            if (!rolemanager.RoleExists("Administrador"))
            {
                rolemanager.Create(new IdentityRole("Administrador"));
            }

            if (!rolemanager.RoleExists("Supervisor"))
            {
                rolemanager.Create(new IdentityRole("Supervisor"));
            }

            if (!rolemanager.RoleExists("Supervisor_treinamento"))
            {
                rolemanager.Create(new IdentityRole("Supervisor_treinamento"));
            }

            if (!rolemanager.RoleExists("Delete"))
            {
                rolemanager.Create(new IdentityRole("Delete"));
            }
        }

       
    }
}
