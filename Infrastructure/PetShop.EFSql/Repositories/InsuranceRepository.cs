using System;
using System.Collections.Generic;
using System.Linq;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;
using PetShop.EFSql.Entities;

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

        public List<Insurance> GetAll()
        {
            return _ctx.Insurances.Select(insurance => new Insurance
                {
                    Id = insurance.Id,
                    Name = insurance.Name,
                    Price = insurance.Price
                })
                .ToList();
        }

        public Insurance DeleteEntry(int id)
        {
            var entity = _ctx.Remove(new InsuranceEntity {Id = id}).Entity;
            _ctx.SaveChanges();
            return new Insurance
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }

        public Insurance UpdateEntry(Insurance insurance)
        {
            var insuranceEntity = new InsuranceEntity()
            {
                Id = insurance.Id,
                Name = insurance.Name,
                Price = insurance.Price
            };
            var entity = _ctx.Update(insuranceEntity).Entity;
            _ctx.SaveChanges();
            return new Insurance
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }
    }
}