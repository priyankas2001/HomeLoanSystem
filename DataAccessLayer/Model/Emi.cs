using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Model
{
    public class Emi
    {
        public double EmiPerMonth { get; set; }

        public double TotalAmountPayable { get; set; }

        public double RateApplicablePerAnnum { get; set; }
    }
}
