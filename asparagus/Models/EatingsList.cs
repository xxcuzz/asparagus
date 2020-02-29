using System;
using System.ComponentModel.DataAnnotations;

namespace asparagus.Models {
    public class EatingsList {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Eating Date")]
        [DataType(DataType.Date)]
        public DateTime EatingDate { get; set; }
        public int Counter { get; set; }
    }
}
