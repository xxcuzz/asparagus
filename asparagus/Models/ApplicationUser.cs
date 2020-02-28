using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace asparagus.Models {
    public class ApplicationUser : IdentityUser {
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime EatingDate { 
            get { 
                return DateTime.Now;
            } 
            set {
                _ = DateTime.Now;
            }
        }
        public int Counter { get; set; }
    }
}
