using System.Collections.Generic;
using System.ComponentModel;

namespace PetShop.EFSql.Entities
{
    public class InsuranceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<PetEntity> Pets { get; set; }
    }
}