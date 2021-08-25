using System.Collections.Generic;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;

namespace mmt.PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public List<Pet> GetAllPets()
        {
            throw new System.NotImplementedException();
        }
    }
}