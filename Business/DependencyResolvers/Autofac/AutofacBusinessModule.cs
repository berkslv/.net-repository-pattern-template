using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Business.Abstract;
using Core.Utilities.Security.Business.Concrete;
using Core.Utilities.Security.DataAccess.Abstract;
using Core.Utilities.Security.DataAccess.Concrete.EntityFramework;
using Core.Utilities.Security.Helpers.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Core.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProuctDal>().As<IProductDal>();
            
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>(); 
        }
    }
}