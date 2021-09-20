using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Core.IServices
{
    public interface IInsuranceService
    {
        Insurance GetById(int id);
        
        List<Insurance> GetAll();
        
        Insurance DeleteEntry(int id);
        Insurance UpdateEntry(Insurance insurance);
    }
}