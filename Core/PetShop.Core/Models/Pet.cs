using System;

namespace mmt.PetShop.Core.Models
{
    public class Pet
    {
        public int PetId { get; set; } 
        
        public String Name { get; set; }
        
        public PetType Type { get; set; }
        
        public DateTime Birthdate { get; set; }
        
        public DateTime SoldDate { get; set; }
        
        public String Color { get; set; }
        
        public double Price { get; set; }
    }
}