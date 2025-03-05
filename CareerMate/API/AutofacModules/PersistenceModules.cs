using Autofac;
using Template.Infrastructure.Persistence;

namespace Template.API.AutofacModules
{
    public class PersistenceModules : Module
    {
        // ToDo
        protected override void Load(ContainerBuilder builder)
        {
            // builder.RegisterAssemblyTypes(typeof(SysAdminRepository).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<AppDbContext>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
