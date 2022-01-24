using Ninject;
using Ninject.Modules;

namespace XMLImporter.WinFormsMVP.Infrastructure.DI
{
    public class CompositionRoot
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static void Wire(params INinjectModule[] modules)
        {
            _ninjectKernel = new StandardKernel(modules);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
