using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestovaciAutofacDB.DbRepositories;
using TestovaciAutofacDB.Interfaces;
using TestovaciAutofac.Models;
using TestovaciAutofac.Interfaces;
using TestovaciAutofac.Controllers;

namespace TestovaciAutofac
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<VersionsController>().InstancePerLifetimeScope();
            builder.RegisterType<SelectionMaskController>().InstancePerLifetimeScope();

            builder.RegisterType<VersionsRepository>().As<IversionsRepository>().InstancePerLifetimeScope();
            builder.RegisterType<VersionsViewModel>().As<IversionsViewModel>().InstancePerLifetimeScope();
            builder.RegisterType<SelectionMaskViewModel>().As<IselectionMaskViewModel>().InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
