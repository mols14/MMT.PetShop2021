using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;

namespace PetShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpPost]
        public Pet Create(Pet pet)
        {
            return _petService.CreatePet(pet);
        }

        [HttpGet]
        public List<Pet> GetAll()
        {
            return _petService.GetAllPets();
        }
        
        // [HttpPut("{id}")]

        // public ActionResult<Pet> Update(int id, [FromBody] Pet dto)
        // {
        //     if (id != dto.PetId)
        //     {
        //         return BadRequest("Id in param must be the same as in object");
        //     }
        //
        //     // return Ok(_petService.UpdatePet(new Pet(
        //     // {
        //     //     PetId = id,
        //     //     Name = dto.Name,
        //     //     Type = dto.Type,
        //     //     Birthdate = dto.Birthdate,
        //     //     SoldDate = dto.SoldDate,
        //     //     Color = dto.Color,
        //     //     Price = dto.Price
        //     // }));
        // }
    }
}