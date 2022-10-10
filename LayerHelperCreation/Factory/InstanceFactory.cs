using Autofac;
using LayerHelperCreation.Shared;

namespace LayerHelperCreation.Factory
{
    public static class InstanceFactory
    {
        private static IContainer _container;
        public static T GetInstance<T>()
        {
            return _container.Resolve<T>(); 
        }

        public static void Start()
        {
            var builder = new ContainerBuilder();

            var uc = new UserConfig();
            uc.Map();

            builder.Register(_ => uc).SingleInstance();

            builder.RegisterType<FileController>().SingleInstance();

            builder.RegisterType<ProgramController>().SingleInstance();

            builder.RegisterType<UnitOfWorkController>().SingleInstance();

            builder.RegisterType<RepositoryController>().SingleInstance();

            builder.RegisterType<BusinessController>().SingleInstance();

            builder.RegisterType<AppServiceController>().SingleInstance();

            IContainer container = builder.Build();
            _container = container;
        }
    }
}
