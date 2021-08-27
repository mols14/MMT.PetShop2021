using System.Collections.Generic;
using System;
using System.Data;
using System.Data.Common;
using mmt.PetShop.Core;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Infrastructure.Data
{
    public static class FakeDB
    {
        public static int id = 1;
        public static IEnumerable<Pet> Pets;

        public static void InitData()
        {

            var pet1 = new Pet()
            {
                PetId = id++,
                Name = "Moishe",
                Type = Rat,
                Birthdate = DateTime.Parse("20/4/2021"),
                SoldDate = DateTime.Today,
                Color = "Grey",
                Price = Convert.ToDouble(6 + "gorrillion")
            };

            var pet2 = new Pet()
            {
                PetId = id++,
                Name = "Lafayette",
                Type = Dog,
                Birthdate = DateTime.Parse("28/1/2021"),
                SoldDate = DateTime.Parse("27/8/2021"),
                Color = "Black",
                Price = 69
            };

            var pet3 = new Pet()
            {
                PetId = id++,
                Name = "Sanic",
                Type = Hedgehog,
                Birthdate = DateTime.Parse("23/6/1991"),
                SoldDate = DateTime.Today,
                Color = "Blue, White and red",
                Price = 1000
            };

            var pet4 = new Pet()
            {
                PetId = id++,
                Name = "Djorch",
                Type = Cat,
                Birthdate = DateTime.Parse("12/2/2017"),
                SoldDate = DateTime.Parse("6/9/2020"),
                Color = "Calico",
                Price = 699
            };
            
            var pet5 = new Pet()
            {
                PetId = id++,
                Name = "Sir. Meowsalot",
                Birthdate = DateTime.Parse()
            }
        }
    }
}