using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    public class User:IdentityUser
    {
        /*[Key]
        public override string Id { get; set; } = Guid.NewGuid().ToString();*/
        /*[Required]
        public string EmailId { get; set; }
        */
        [Required]
        public string Password { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string CityCode { get; set; }
        [Required]
        public string StateCode { get; set; }
        [Required]
        public string CountryCode { get; set; }

    }
}
