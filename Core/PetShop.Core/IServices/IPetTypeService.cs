using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Core.IServices
{
    public interface IPetTypeService
    {
        List<PetType> GetAllPetTypes();
        PetType GetPetType(int id);
    }
}