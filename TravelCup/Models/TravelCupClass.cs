using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelCup.Models
{
    public class TravelCupClass
    {
        public int Id { get; set; }
        public string CupsTitle { get; set; }

        [Display(Name = "ManufactureDate")]
        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Shape { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
