using Autofac;
using Autofac.Core;
using Autofac.Util;
using AutoFacDemoLibrary.BusinessLogic;
using AutoFacDemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDemo
{
    public static class AutoFacContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            Assembly assembly = Assembly.Load(nameof(AutoFacDemoLibrary));
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutoFacDemoLibrary)))
            //    .Where(x => x!.Namespace!.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().Where(t => t.Name.StartsWith("I")));
            builder.RegisterAssemblyTypes(assembly)
                           .Where(x => x!.Namespace!.Contains("Utilities"))
                           .As(t => t.GetInterfaces().Where(t => t.Name.StartsWith("I")));
            return builder.Build();
        }
    }
}
