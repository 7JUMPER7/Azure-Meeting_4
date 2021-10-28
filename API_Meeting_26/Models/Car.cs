using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Meeting_26.Models
{
    public class Car
    {
        public int Id { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
    }
}
