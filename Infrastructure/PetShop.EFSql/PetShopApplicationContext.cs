using Microsoft.EntityFrameworkCore;
using mmt.PetShop.Core.Models;
using PetShop.EFSql.Entities;

namespace PetShop.EFSql
{
    public class PetShopApplicationContext : DbContext
    {
        public PetShopApplicationContext(DbContextOptions<PetShopApplicationContext> options) : base(options) { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetEntity>()
                .HasOne(petEntity => petEntity.Insurance)
                .WithMany(insuranceEntity => insuranceEntity.Pets);
            
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 1, Name = "SafeStuff", Price = 69});
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 2, Name = "NotSoSafeStuff", Price = 420});
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 3, Name = "UnsafeStuff", Price = 1337});
                
        }

        public DbSet<InsuranceEntity> Insurances { get; set; }
        public DbSet<OwnerEntity> Owners { get; set; }
        public DbSet<PetEntity> Pets { get; set; }
    }
}