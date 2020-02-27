using System;
using System.ComponentModel.DataAnnotations;

namespace asparagus.Models {
    public class ApplicationUser {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static int m_Counter = 0;
    }
}
