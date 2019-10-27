using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlphaRangers.Models
{
    [Table("Baja")]
    public class Baja
    {
        [Key]
        public int ID { get; set; }
        public int Velocidade { get; set; }
        public int FreioQtd { get; set; }
        public int VoltasQtd { get; set; }
        public int Temperatura { get; set; }
        public int Bateria { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}