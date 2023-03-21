using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(User userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOut();
    }
}