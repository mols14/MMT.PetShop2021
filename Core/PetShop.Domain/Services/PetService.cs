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
    }
}