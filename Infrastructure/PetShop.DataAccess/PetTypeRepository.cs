using System;
using System.Collections.Generic;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;

namespace mmt.PetShop.Infrastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public List<PetType> GetAllPetTypes()
        {
            return FakeDB.PetTypes;
        }
        public PetType GetPetType(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}