using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PingPongProject.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }

        [Display(Name = "Skill Level")]
        public string SkillLevel { get; set; }
        [Required, Display(Name = "Email Address"), EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }
    }
}