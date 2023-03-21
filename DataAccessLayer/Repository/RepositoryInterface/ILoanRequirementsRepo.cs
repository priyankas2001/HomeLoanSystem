using DataAccessLayer.Model;
using System;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public interface ILoanRequirementsRepo
    {
        Task<dynamic> AddRequirement(LoanRequirements requirements);
        Task<string> DeleteRequirement(Guid Id);
        Task<LoanRequirements> GetRequirementById(Guid Id);
        Task<LoanRequirements> UpdateRequirementById(LoanRequirements requirements);
    }
}