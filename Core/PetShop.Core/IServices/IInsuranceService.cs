using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Core.IServices
{
    public interface IInsuranceService
    {
        Insurance GetById(int id);
    }
}