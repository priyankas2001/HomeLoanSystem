using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace DataAccessLayer.Model
{
    public class Property
    {
        [Required]
        [Key]
        public Guid Id{get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public double Cost { get; set; }

        [Required]
        public decimal RegistrationCost { get; set; }

    }
}
