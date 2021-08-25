using System;
using Microsoft.Extensions.DependencyInjection;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Domain.IRepositories;
using mmt.PetShop.Domain.Services;

namespace PetMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Her foregår dependency-Injections. Pointen bag dette er i store træk samme tankegang som GOF - Facade-pattern
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetService, PetService>();
            // serviceCollection.AddScoped<ICarMakeRepository, CarMakeRepository>();
            // serviceCollection.AddScoped<ICarService, CarService>();

            // var serviceProvider = serviceCollection.BuildServiceProvider();
            // var carService = serviceProvider.GetRequiredService<ICarService>();
            // new Printer(carService);

            Console.ReadLine();
            /*////then build provider 
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();*/
        }
    }
}