using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;

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

        public void Start()
        {
            _petService.GetAllPets();
            ShowWelcomeGreeting();
            StartLoop();
        }

        
        
        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    ShowAllPets();
                }

                if (choice == 2)
                {
                    CreatePet();
                }

                if (choice == 3)
                {
                    DeletePet();
                }

                // if (choice == 4)
                // {
                //     UpdatePet();
                // }
                //
                // if (choice == 5)
                // {
                //     GetPetByPetType();
                // }
                //
                // if (choice == 6)
                // {
                //     ShowMostExpensivePets();
                // }
                
                if (choice == 7)
                {
                    ShowCheapestPets();
                }
            }
        }

        private void ShowCheapestPets()
        {
            Console.WriteLine(StringConstants.FiveCheapestPets);
            List<Pet> cheapestPets = _petService.GetFiveCheapestPets();
            Console.WriteLine(cheapestPets);
        }

        private void ShowWelcomeGreeting() 
        {
            
            Console.WriteLine(StringConstants.Greet); 
        }
        private void DeletePet()
        {
            int idToDelete = int.Parse(Console.ReadLine() ?? string.Empty);
            if (idToDelete != null)
            {
                _petService.DeletePet(idToDelete);
                Console.WriteLine($"A pet with the id {idToDelete} has been successfully removed from the list of pets");
            }
        }

        private void CreatePet()
        {
            List<Pet> pets = _petService.GetAllPets();
            var pet = new Pet();
            
            Console.WriteLine(StringConstants.Id);
            var idString = Console.ReadLine();
            int id;

            if (int.TryParse(idString, out id))
            {
                pet.PetId = id;
            }
            
            Console.WriteLine(StringConstants.Name);
            var name = Console.ReadLine();
            pet.Name = name;
            
            Console.WriteLine(StringConstants.Color);
            var color = Console.ReadLine();
            pet.Color = color;
            
            Console.WriteLine(StringConstants.Type);
            List<PetType> petTypes = _petTypeService.GetAllPetTypes();

            foreach (PetType petType in petTypes)
            {
                Console.WriteLine(petType.Id + ". " + petType.Name);
            }

            pet.Type = _petTypeService.GetPetType(GetPetTypeSelection());
            
            Console.WriteLine(pet.Type.Name);
            
            Console.WriteLine(StringConstants.Price);
            var priceString = Console.ReadLine();
            double price;

            if (double.TryParse(priceString, out price))
            {
                pet.Price = price;
            }
            
            Console.WriteLine(StringConstants.BirthDate);
            string birthDate = Console.ReadLine();
            var parsedBirthDate = DateTime.Parse(birthDate);

            pet.Birthdate = parsedBirthDate;
            
            Console.WriteLine(StringConstants.SoldDate);
            string soldDate = Console.ReadLine();
            var parsedSoldDate = DateTime.Parse(soldDate);

            pet.SoldDate = parsedSoldDate;
            
            pets.Add(pet);
            
            Console.WriteLine("Pet has been succesfully added to Database.");

        }

        private void UpdatePet()
        {
            Console.WriteLine(StringConstants.TypeId);
            int updateId = int.Parse(Console.ReadLine());
            var updatePet = _petService.SearcById(updateId);
            
            Console.WriteLine(StringConstants.TypeName);
            var updateName = Console.ReadLine();
            
            Console.WriteLine(StringConstants.TypePrice);
            double updatePrice = double.Parse(Console.ReadLine());

            _petService.UpdatePet(new Pet()
            {
                PetId = updatePet.PetId,
                Name = updateName,
                Price = updatePrice,
                Birthdate = updatePet.Birthdate,
                Color = updatePet.Color,
                SoldDate = updatePet.SoldDate,
                Type = updatePet.Type
            });
        }
        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
        
        private void ShowMainMenu()
        {
            Console.WriteLine(StringConstants.ShowAllPets);
            Console.WriteLine(StringConstants.CreatePet);
            Console.WriteLine(StringConstants.DeletePet);
            Console.WriteLine(StringConstants.UpdatePet);
            Console.WriteLine(StringConstants.SearchByType);
            Console.WriteLine(StringConstants.ShowMostExpensivePets);
            Console.WriteLine(StringConstants.ShowCheapestPets);
            Console.WriteLine(StringConstants.ExitApplication);
            Console.WriteLine("\n");
        }
        private void ShowAllPets()
        {
            List<Pet> allPets = _petService.GetAllPets();

            foreach (Pet pet in allPets)
            {
                Console.WriteLine("Id: " + pet.PetId + " Name: " + pet.Name + " Color: " + pet.Color + " Type: " + pet.Type.Name + " Birthdate: " + pet.Birthdate + " Price: " + pet.Price + " SoldDate: " + pet.SoldDate);
            }
            Console.WriteLine("\n");
        }
        
        private int GetPetTypeSelection()
        {
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
    }
}