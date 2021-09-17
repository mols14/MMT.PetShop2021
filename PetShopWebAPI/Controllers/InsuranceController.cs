using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mmt.PetShop.Core.IServices;
using mmt.PetShop.Core.Models;

namespace PetShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceService _insuranceService;
        public InsuranceController(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }

        [HttpGet("{id}")]
        public ActionResult<Insurance> ReadById(int id)
        {
            try
            {
                return Ok(_insuranceService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, "I shitted myself");
            }
            
        }

        [HttpGet]
        public ActionResult<List<Insurance>> GetAll()
        {
            try
            {
                return Ok(_insuranceService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, "FARDED");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Insurance> DeleteEntry(int id)
        {
            try
            {
                return Ok(_insuranceService.DeleteEntry(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, "IM retarded");
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Insurance> UpdateFromId(int id, [FromBody] Insurance insurance)
        {
            try
            {
                if (id != insurance.Id)
                {
                    return BadRequest("ID in insurance must match param ID");
                }
                return Ok(_insuranceService.UpdateEntry(insurance));
            }
            catch (Exception e)
            {
                return StatusCode(500, "dint work");
            }
        }
    }
}