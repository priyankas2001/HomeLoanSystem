using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    public class Advisor:IdentityUser
    {

        [Required]
        public string EmailId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
