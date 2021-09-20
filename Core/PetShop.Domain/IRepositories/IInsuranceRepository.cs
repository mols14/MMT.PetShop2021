using System.Collections.Generic;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Domain.IRepositories
{
    public interface IInsuranceRepository
    {
        Insurance GetById(int Id);
        List<Insurance> GetAll();
        Insurance DeleteEntry(int id);
        Insurance UpdateEntry(Insurance insurance);
    }
}