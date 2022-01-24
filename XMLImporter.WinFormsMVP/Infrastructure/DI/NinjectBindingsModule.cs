using Ninject.Modules;
using XMLImporter.Business.Interfaces;
using XMLImporter.Business.Services;
using XMLImporter.WinFormsMVP.MockData;

namespace XMLImporter.WinFormsMVP.Infrastructure.DI
{
    public class NinjectBindingsModule : NinjectModule
    {
        public override void Load()
        {
            //register bindings
            Bind<IProjectRepository>().To<ProjectRepository>();
            Bind<IDomainRepository>().To<DomainRepository>();
            Bind<IFileService>().To<FileService>();
        }
    }
}
