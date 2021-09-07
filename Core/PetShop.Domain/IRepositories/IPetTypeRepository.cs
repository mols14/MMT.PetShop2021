using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        List<PetType> GetAllPetTypes();
        PetType GetPetType(int id);
    }
}