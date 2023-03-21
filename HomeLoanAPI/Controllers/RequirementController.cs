using DataAccessLayer.Model;
using DataAccessLayer.Repository.RepositoryImplementation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequirementController : ControllerBase
    {
        private readonly ILoanRequirementsRepo requirementsRepo;

        public RequirementController(ILoanRequirementsRepo requirementsRepo)
        {
            this.requirementsRepo = requirementsRepo;
        }

        [HttpPost("Add-requirement")]
        public async Task<IActionResult> AddRequirement([FromForm] LoanRequirements requirement)
        {

            try
            {
                var response = await this.requirementsRepo.AddRequirement(requirement);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("update-requirement")]

        public async Task<IActionResult> UpdateRequirement([FromForm] LoanRequirements requirements)
        {
            try
            {
                var response = await this.requirementsRepo.UpdateRequirementById(requirements);
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
