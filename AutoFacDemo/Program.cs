// See https://aka.ms/new-console-template for more information
using Autofac;
using AutoFacDemo;
using AutoFacDemoLibrary.BusinessLogic;

Console.WriteLine("Hello, World!");

var container = AutoFacContainerConfig.Configure();

using(var scope = container.BeginLifetimeScope())
{
    var app = scope.Resolve<IApplication>();
    app.Run();
}