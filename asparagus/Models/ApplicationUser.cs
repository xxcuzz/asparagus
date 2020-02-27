using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace asparagus.Models {
    /*public class ApplicationUser {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        
    }*/
    public class ApplicationUser : IdentityUser {
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime EatingDate { get; set; }
        public int Counter { get; set; }
    }
}
