using System.Collections;
using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Domain.IRepositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();

        Pet CreatePet(Pet pet);

        Pet DeletePet(int id);

        Pet ReadById(int id);
    }
}