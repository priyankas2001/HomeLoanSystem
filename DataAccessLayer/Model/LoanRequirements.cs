using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    public class LoanRequirements
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public double LoanAmount { get; set; }

        [Required]

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int LoanDurationInMonths { get; set; }

        [Required]
        public DateTime LoanStartDate { get; set; }

    }
}
