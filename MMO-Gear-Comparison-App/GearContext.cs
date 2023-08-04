using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_Gear_Comparison_App
{
    public class GearContext : DbContext
    {
        public GearContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The name for our database
            // Server = the local server we're using
            // Trusted_Connection = indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MMOGearComparsionApp;Trusted_Connection=True;");
        }
        // Tell EF Core to track Gear in the database
        public DbSet<Gear> Gears { get; set; } 
    }
}
