using System.Collections.Generic;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;

namespace mmt.PetShop.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        private readonly IPetTypeRepository _petTypeRepository;

        public PetTypeService(IPetTypeRepository repository)
        {
            _petTypeRepository = repository;
        }
        public List<PetType> GetAllPetTypes()
        {
            return _petTypeRepository.GetAllPetTypes();
        }

        public PetType GetPetType(int id)
        {
            return _petTypeRepository.GetPetType(id);
        }
    }
}