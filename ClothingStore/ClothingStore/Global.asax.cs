using Autofac;
using Autofac.Integration.Mvc;
using ClothingStore.Data;
using ClothingStore.Data.QueryRepository;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ClothingStore
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

            builder.RegisterType<DatabaseCommandContext>().InstancePerDependency();
            builder.RegisterType<DatabaseQueryContext>().InstancePerDependency();
            builder.RegisterType(typeof(IQuery)).AsImplementedInterfaces().InstancePerDependency();
            builder.RegisterType(typeof(ICommand)).AsImplementedInterfaces().InstancePerDependency();

            builder.RegisterAssemblyTypes(typeof(IQueryRepository<>).Assembly).AsClosedTypesOf(typeof(IQueryRepository<>));
            builder.RegisterAssemblyTypes(typeof(IQueryContext<>).Assembly).AsClosedTypesOf(typeof(IQueryContext<>));
            builder.RegisterAssemblyTypes(typeof(ICommandContext<>).Assembly).AsClosedTypesOf(typeof(ICommandContext<>));

            builder.RegisterType<ProductQueryRespository>().As<IProductQueryRespository>().InstancePerDependency();

            builder.RegisterType<ProductCommandRespository>().As<IProductCommandRespository>().InstancePerDependency();

            builder.RegisterType<GetAllProductQueryHandler>().As<IQueryHandler<GetAllProductQuery>>().InstancePerDependency();
            builder.RegisterType<InsertProductCommandHandler>().As<ICommandHandler<InsertProductCommand>>().InstancePerDependency();

            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>().InstancePerDependency();
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>().InstancePerDependency();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
