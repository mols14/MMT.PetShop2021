using System;
using mmt.PetShop.Core.IServices;

namespace PetMenu
{
    public class PetMenu
    {
        private static IPetService _petService;
        private readonly IPetTypeService _petTypeService;

        public PetMenu(IPetService petService, IPetTypeService petTypeService)
        {
            _petTypeService = petTypeService;
            _petService = petService;
        }

        public static void BootUp()
        {
            _petService.GetAllPets();
            Console.WriteLine("Welcome to the Pet Shop. How can I be of assistance?");
        }
    }
}