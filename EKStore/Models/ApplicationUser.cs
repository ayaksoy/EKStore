using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EKStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Image { get; set; }
        public int Age { get; set; }
        public double Balance { get; set; } = 1500;
        [NotMapped]
        public string? Role { get; set; }


    }
}

