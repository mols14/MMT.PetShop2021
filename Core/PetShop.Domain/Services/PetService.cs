using System;
using System.Collections.Generic;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;
using System.Linq;

namespace mmt.PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        IEnumerable<Pet> Pets;
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        
        public List<Pet> GetAllPets()
        {
            return _petRepository.ReadPets().ToList();
        }

        public Pet addPet(string name, string petType, DateTime birthdate, DateTime soldDate, double price)
        {
            throw new NotImplementedException();
        }

        public Pet CreatePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void DeletePet(int Id)
        {
            throw new NotImplementedException();
        }

        public Pet UpdatePet()
        {
            throw new NotImplementedException();
        }

        public List<Pet> SortByPrice()
        {
            throw new NotImplementedException();
        }

        public List<Pet> SortByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Pet> SortByType()
        {
            throw new NotImplementedException();
        }

        public List<Pet> getFiveCheapestPets()
        {
            throw new NotImplementedException();
        }
    }
}