using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities{
    public class Page {
        [Key]
        public int idPage { get; set; }

        [StringLength (50)]
        public string description { get; set; }
        public bool state { get; set; }
    }
}