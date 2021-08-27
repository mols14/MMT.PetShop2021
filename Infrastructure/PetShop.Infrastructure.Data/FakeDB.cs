using System.Collections.Generic;
using System;
using mmt.PetShop.Core;

namespace mmt.PetShop.Infrastructure.Data
{
    public static class FakeDB
    {
        public static int id = 1;
        public static IEnumerable<Pet> Pets;

        public static void InitData()
        {
            
            var pet1 = new PetShop()
            {
                PetID = id++,
                Name = "Moishe",
                Type = "Rat",
                Birthdate = DateTime.Parse("20/4/2021")
                SoldDate
            }
        }
    }
}