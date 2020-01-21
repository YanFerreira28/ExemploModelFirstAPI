using ModelAPI.Contracts;
using ModelAPI.Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ModelAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.RegisterType<IRepositoryCliente, RepositoryCliente>();
            container.RegisterType<IRepositoryProduto, RepositoryProduto>();
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}