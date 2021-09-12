using System;
using Microsoft.Extensions.DependencyInjection;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Domain.IRepositories;
using mmt.PetShop.Domain.Services;
using mmt.PetShop.Infrastructure.Data;

namespace PetMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var petService = serviceProvider.GetRequiredService<IPetService>();
            var petTypeService = serviceProvider.GetRequiredService<IPetTypeService>();
            
            PetMenu petMenu = new PetMenu(petService, petTypeService);
            petMenu.Start();

        }
    }
}