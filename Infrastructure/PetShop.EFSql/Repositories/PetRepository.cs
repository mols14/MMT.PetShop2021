using System.Collections.Generic;
using System.Linq;
using mmt.PetShop.Core.Models;
using mmt.PetShop.Domain.IRepositories;
using PetShop.EFSql.Entities;

namespace PetShop.EFSql.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetShopApplicationContext _ctx;

        public PetRepository(PetShopApplicationContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Pet> ReadPets()
        {
            return _ctx.Pets.Select(pet => new Pet
            {
                PetId = pet.Id,
                Name = pet.Name,
                Type = pet.Type,
                Color = pet.Color,
                Birthdate = pet.BirthDate,
                SoldDate = pet.SoldDate
            });
        }

        public Pet CreatePet(Pet pet)
        {
            var beforeSaveEntity = new PetEntity
            {
                Name = pet.Name,
                BirthDate = pet.Birthdate,
                SoldDate = pet.SoldDate
            };
            var afterSaveEntity = _ctx.Pets.Add(beforeSaveEntity).Entity;
            _ctx.SaveChanges();
            return new Pet
            {
                PetId = afterSaveEntity.Id,
                Name = afterSaveEntity.Name,
                Birthdate = afterSaveEntity.BirthDate,
                SoldDate = afterSaveEntity.SoldDate
            };
        }

        public Pet DeletePet(int id)
        {
            _ctx.Pets.Remove(new PetEntity {Id = id});
            _ctx.SaveChanges();
            return new Pet
            {
                PetId = id
            };
        }

        public Pet ReadById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}