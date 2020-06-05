using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
