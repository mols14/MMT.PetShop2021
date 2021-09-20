using System.Collections.Generic;
using System.Linq;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;

namespace mmt.PetShop.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {

        private static List<Pet> _pets = new List<Pet>();
        public IEnumerable<Pet> ReadPets()
        {
            return FakeDB.Pets;
        }

        public Pet CreatePet(Pet pet)
        {
            pet.PetId = FakeDB.id++;
            var pets = FakeDB.Pets.ToList();
            pets.Add(pet);
            FakeDB.Pets = pets;
            return pet;
        }

        public void DeletePet(int Id)
        {
            var pets = FakeDB.Pets.ToList();
            var pet2bDeleted = pets.FirstOrDefault(pet => pet.PetId == Id);
            pets.Remove(pet2bDeleted);
            FakeDB.Pets = pets;
        }

        public Pet ReadById(int id)
        {
            foreach (var pet in _pets)
            {
                if (pet.PetId == id)
                {
                    return pet;
                }
            }

            return null;
        }
    }
}