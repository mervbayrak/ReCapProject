using Autofac;
using CarRentalSystem.Business.Abstract;
using CarRentalSystem.Business.Concrete;
using CarRentalSystem.DataAccess.Abstract;
using CarRentalSystem.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IBrandService>().As<BrandManager>().SingleInstance();
            builder.RegisterType<ICarService>().As<CarManager>().SingleInstance();
            builder.RegisterType<IColorService>().As<ColorManager>().SingleInstance();
            builder.RegisterType<ICustomerService>().As<CustomerManager>().SingleInstance();
            builder.RegisterType<IRentalService>().As<RentalManager>().SingleInstance();
            builder.RegisterType<IUserService>().As<UserManager>().SingleInstance();

            builder.RegisterType<IBrandDal>().As<EfBrandDal>().SingleInstance();
            builder.RegisterType<ICarDal>().As<EfCarDal>().SingleInstance();
            builder.RegisterType<IColorDal>().As<EfColorDal>().SingleInstance();
            builder.RegisterType<ICustomerDal>().As<EfCustomerDal>().SingleInstance();
            builder.RegisterType<IRentalDal>().As<EfRentalDal>().SingleInstance();
            builder.RegisterType<IUserDal>().As<EfUserDal>().SingleInstance();
        }
       
    }
}
