using System;

namespace mmt.PetShop.Core.Models
{
    public class Pet
    {
        public int PetId { get; set; } 
        
        public string Name { get; set; }
        
        public string type { get; set; }
        
        public string gender { get; set; }
        
        public DateTime Birthdate { get; set; }
        
        public DateTime SoldDate { get; set; }
        
        public double price { get; set; }
    }
}