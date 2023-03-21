using DataAccessLayer.Model;
using System.Collections.Generic;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public interface ICalculator
    {
        Emi CalculateEmi(LoanRequirements requirements);
    }
}