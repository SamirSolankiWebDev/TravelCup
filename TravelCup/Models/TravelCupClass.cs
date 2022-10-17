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
        [StringLength(60, MinimumLength = 3)]
        public string Shape { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }

    }
}
