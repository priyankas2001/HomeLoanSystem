using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountRepository(IServiceProvider serviceProvider, UserManager<User> userManager, SignInManager<User> signInManager
            )
        {
            _serviceProvider = serviceProvider;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(User userModel)
        {

            var userManager = _serviceProvider.GetRequiredService<UserManager<User>>();
            var email = userManager.Users.Where(x => x.Email == userModel.Email).FirstOrDefault();
            if (email != null)
            {

                return IdentityResult.Failed(new IdentityError {
                    Code="Signup Failed",
                    Description="User already Exists"
                });
            }
            else
            {
                var user = new User()
                {
                    Email = userModel.Email,
                    UserName = userModel.Email.Substring(0, userModel.Email.IndexOf("@")),
                    MobileNumber = userModel.MobileNumber,
                    StateCode = userModel.StateCode,
                    CityCode = userModel.CityCode,
                    CountryCode = userModel.CountryCode,
                };

                var res = await _userManager.CreateAsync(user, userModel.Password);
                await _userManager.AddToRoleAsync(user, "Customer");
                return res;
            }
        }

        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
           return await _signInManager.PasswordSignInAsync(signInModel.UserName,signInModel.Password,true,false);
        }
        
        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

       
    }
}
