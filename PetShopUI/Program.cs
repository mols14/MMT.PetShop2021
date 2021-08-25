using System;

namespace PetMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICarRepository, CarRepository>();
            serviceCollection.AddScoped<ICarMakeRepository, CarMakeRepository>();
            serviceCollection.AddScoped<ICarService, CarService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var carService = serviceProvider.GetRequiredService<ICarService>();
            new Printer(carService);

            Console.ReadLine();
            /*////then build provider 
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();*/
        }
    }
}