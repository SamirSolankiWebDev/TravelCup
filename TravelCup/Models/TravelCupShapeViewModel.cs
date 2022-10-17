using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TravelCup.Models
{
    public class TravelCupShapeViewModel
    {
        public List<TravelCupClass> Cups { get; set; }
        public SelectList RechangeSize { get; set; }
        public string CupsView { get; set; }
        public string SearchString { get; set; }
    }
}
