using System.Collections.Generic;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using mmt.PetShop.Core;
using mmt.PetShop.Core.Models;

namespace mmt.PetShop.Infrastructure.Data
{
    public static class FakeDB
    {
        public static int id = 1;
        public static int petTypeId = 1;
        public static List<Pet> Pets = new List<Pet>();
        public static List<PetType> PetTypes = new List<PetType>();

        public static void InitData()
        {

            var rat = new PetType
            {
                Id = petTypeId++,
                Name = "Rat"
            };
            PetTypes.Add(rat);

            PetType hedgehog = new PetType();
            hedgehog.Id = petTypeId++;
            hedgehog.Name = "Hedgehog";
            PetTypes.Add(hedgehog);

            PetType dog = new PetType();
            dog.Id = petTypeId++;
            dog.Name = "Dog";
            PetTypes.Add(dog);

            PetType cat = new PetType();
            cat.Id = petTypeId++;
            cat.Name = "Cat";
            PetTypes.Add(cat);
            
            
            
            var pet1 = new Pet()
            {
                PetId = id++,
                Name = "Moishe",
                Type = rat,
                Birthdate = DateTime.Parse("20/4/2021"),
                SoldDate = DateTime.Today,
                Color = "Grey",
                Price = 6
            }; Pets.Add(pet1);

            var pet2 = new Pet()
            {
                PetId = id++,
                Name = "Lafayette",
                Type = dog,
                Birthdate = DateTime.Parse("28/1/2021"),
                SoldDate = DateTime.Parse("27/8/2021"),
                Color = "Black",
                Price = 69
            }; Pets.Add(pet2);

            var pet3 = new Pet()
            {
                PetId = id++,
                Name = "Sanic",
                Type = hedgehog,
                Birthdate = DateTime.Parse("23/6/1991"),
                SoldDate = DateTime.Today,
                Color = "Blue, White and red",
                Price = 1000
            }; Pets.Add(pet3);

            var pet4 = new Pet()
            {
                PetId = id++,
                Name = "Djorch",
                Type = cat,
                Birthdate = DateTime.Parse("12/2/2017"),
                SoldDate = DateTime.Parse("6/9/2020"),
                Color = "Calico",
                Price = 699
            }; Pets.Add(pet4);

            var pet5 = new Pet()
            {
                PetId = id++,
                Name = "Oliver",
                Type = cat,
                Birthdate = DateTime.Parse("7/5/2020"),
                SoldDate = DateTime.Parse("12/6/2020"),
                Color = "Tabby",
                Price = 1100
            }; Pets.Add(pet5);

        }
    }
}