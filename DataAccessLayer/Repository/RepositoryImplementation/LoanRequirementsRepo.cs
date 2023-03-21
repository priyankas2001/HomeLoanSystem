using DataAccessLayer.Data;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public class LoanRequirementsRepo : ILoanRequirementsRepo
    {
        private readonly AppDbContext context;
        private readonly ILogger<LoanRequirements> _logger;
        public LoanRequirementsRepo(AppDbContext context, ILogger<LoanRequirements> logger)
        {
            this.context = context;
            _logger = logger;

        }

        public async Task<dynamic> AddRequirement(LoanRequirements requirements)
        {
            if (requirements.Id == Guid.Empty || requirements.Id == null)
            {
                await this.context.LoanRequirements.AddAsync(requirements);
                this.context.SaveChanges();
                if (this.context.SaveChanges() > 0)
                {
                    _logger.LogInformation($"requirement added with id {requirements.Id}");
                }
                return requirements;
            }
            else
            {
                return new { message = "Requirement can not be added." };
            }

        }
        public async Task<LoanRequirements> UpdateRequirementById(LoanRequirements requirements)
        {
            var entityToBeUpdated = await this.context.LoanRequirements.Where(x=>x.Id==requirements.Id).FirstOrDefaultAsync();
            if (entityToBeUpdated.Id != null)
            {
                this.context.Entry(entityToBeUpdated).State = EntityState.Modified;
                await this.context.SaveChangesAsync();
                return requirements;
            }
            else
            {
                return null;
            }
        }

        public async Task<LoanRequirements> GetRequirementById(Guid Id)
        {
            var res = await this.context.LoanRequirements.FindAsync(Id);
            return res;
        }

        public async Task<string> DeleteRequirement(Guid Id)
        {
            var res = await this.context.LoanRequirements.FindAsync(Id);
            this.context.Remove(res);
            this.context.SaveChanges();
            var requirementExists = this.context.LoanRequirements.Any(x => x.Id == Id);
            if (requirementExists)
            {
                return $"Loan Requirement with {Id} is removed successfully";
            }
            else
            {
                return $"Loan Requirement with {Id} cannot be removed ";
            }
        }
    }
}
