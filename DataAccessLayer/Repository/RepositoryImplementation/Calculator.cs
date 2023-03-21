using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public class Calculator : ICalculator
    {
        public Emi CalculateEmi(LoanRequirements requirements)
        {
            var P = requirements.LoanAmount;
            var R = 7.5 / 12 / 100;
            var N = requirements.LoanDurationInMonths;
            var denominator = (Math.Pow((1 + R), N)) - 1;
            var emi = P * R * Math.Pow((1 + R), N) / denominator;
            var list = new Emi()
            {
                EmiPerMonth = emi,
                TotalAmountPayable = (emi * N),
                RateApplicablePerAnnum = R * 1200
            };
            return list;
        }
    }
}
