using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace asparagus.Models {
    public class ApplicationUser : IdentityUser {
        [Display(Name = "Eating Date")]
        [DataType(DataType.Date)]
        public DateTime EatingDate { get; set; }
        public int Counter { get; set; }
    }
}
