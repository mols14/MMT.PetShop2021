using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Pet addPet(string name, PetType petType, DateTime birthdate, DateTime soldDate, string color, double price)
        {
            var pet = new Pet()
            {
                Name = name,
                Type = petType,
                Birthdate = birthdate,
                SoldDate = soldDate,
                Color = color,
                Price = price
            };
            return pet;
        }

        public Pet CreatePet(Pet pet)
        {
            return _petRepository.CreatePet(pet);
        }

        public void DeletePet(int Id)
        {
            _petRepository.DeletePet(Id);
        }

        public Pet UpdatePet()
        {
            throw new NotImplementedException();
        }

        public List<Pet> SortByPrice()
        {
            return _petRepository.ReadPets().OrderByDescending(pet => pet.Price).ToList();
        }

        public List<Pet> SortByName(string name)
        {
            return _petRepository.ReadPets().Where(pet => pet.Name.Contains(name)).ToList();
        }

        public List<Pet> SortByType(PetType petType)
        {
            // return _petRepository.ReadPets().Where(pet => pet.PetType.Contains(petType)).ToList();
            throw new NotImplementedException();
        }

        public List<Pet> getFiveCheapestPets()
        {
            Pets = new List<Pet>();
            var pet = Pets.ToList();
            pet.Clear();
            var list = _petRepository.ReadPets().ToList();
            foreach (var pets in list)
            {
                if (pets.SoldDate.Year == 0001)
                {
                    pet.Add(pets);
                }
            }

            return pet.OrderBy(pets => pets.Price).Take(5).ToList();
        }
    }
}