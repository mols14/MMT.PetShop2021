using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Domain.IRepositories
{
    public interface IInsuranceRepository
    {
        Insurance GetById(int Id);
    }
}