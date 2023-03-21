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
    [Route("[Controller]")]
    public class LoanController:ControllerBase
    {
        private readonly ICalculator _calculator;
        public LoanController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("emi")]
        public IActionResult CalculateEmi([FromForm] LoanRequirements requirements)
        {
            var result = _calculator.CalculateEmi(requirements);
            return Ok(result);
        }


    }
}
