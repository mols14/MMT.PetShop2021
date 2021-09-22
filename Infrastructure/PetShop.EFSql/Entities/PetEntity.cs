using System;
using System.Runtime.InteropServices;
using mmt.PetShop.Core.Models;

namespace PetShop.EFSql.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public PetType Type { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public int InsuranceId { get; set; }
        public InsuranceEntity Insurance { get; set; }
        
    }
}