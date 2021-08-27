using System;
using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Core.IServices
{
    public interface IPetService
    {
        List<Pet> GetAllPets();

        Pet addPet(string name, string petType, DateTime birthdate, 
            DateTime soldDate, double price);

        Pet CreatePet(Pet pet);

        void DeletePet(int Id);

        Pet UpdatePet();

        List<Pet> SortByPrice();

        List<Pet> SortByName(string name);

        List<Pet> SortByType();

        List<Pet> getFiveCheapestPets();
        
        


    }
}