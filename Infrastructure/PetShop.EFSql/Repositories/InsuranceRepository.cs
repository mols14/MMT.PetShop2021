using System;
using System.Linq;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;

namespace PetShop.EFSql.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly PetShopApplicationContext _ctx;

        public InsuranceRepository(PetShopApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Insurance GetById(int id)
        {
            return _ctx.Insurances
                .Select(insuranceEntity => new Insurance
                    {
                        Id = insuranceEntity.Id,
                        Name = insuranceEntity.Name,
                        Price = insuranceEntity.Price
                    })
                .FirstOrDefault(insurance => insurance.Id == id);
        }
    }
}