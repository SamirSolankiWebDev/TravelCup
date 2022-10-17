using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelCup.Models;

namespace TravelCup.Data
{
    public class MvcTravelCupContext : DbContext
    {
        public MvcTravelCupContext(DbContextOptions<MvcTravelCupContext> options)
            : base(options)
        {
        }

        public DbSet<TravelCup> TravelCup { get; set; }
    }
}
