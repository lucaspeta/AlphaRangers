using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlphaRangers.Models
{
    [Table("Flags")]
    public class Flags
    {
        [Key]
        public int ID { get; set; }
        public bool Green { get; set; }
        public bool Yellow {get; set;}
        public bool Red { get; set; }
        public bool Shutdown { get; set; }
        public bool WasReaded { get; set; }
        public DateTime CreatedDate { get; set; }

        public Flags() { }
    }
}