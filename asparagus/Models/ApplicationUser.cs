using System;
using Microsoft.AspNetCore.Identity;

namespace asparagus.Models {
    public class ApplicationUser : IdentityUser {
        public int Counter { get; set; }
    }
}
