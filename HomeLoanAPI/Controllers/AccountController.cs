using DataAccessLayer.Model;
using DataAccessLayer.Repository.RepositoryImplementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountRepository accountRepository,ILogger<AccountController> logger)
        {
            _accountRepository = accountRepository;
            _logger = logger;
        }


        [AllowAnonymous]
        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp([FromForm] User userModel)
        {
            try
            {
                var res = await _accountRepository.CreateUserAsync(userModel);
                return Ok(res);
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]

        public async Task<IActionResult> Login([FromForm] SignInModel signIn)
        {
            try
            {
                var result = await _accountRepository.PasswordSignInAsync(signIn);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("logout")]
        public async Task LogOut()
        {
            await _accountRepository.SignOut();
        }
    }
}
