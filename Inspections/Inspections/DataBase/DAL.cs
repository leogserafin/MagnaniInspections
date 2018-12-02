using Inspections.Entities;
using System.Data.Entity;

namespace Inspections.DataBase
{
    class DAL : DbContext
    {
        public DAL() : base("MagnaniInspections"){}

        public DbSet<Pole> Poles { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
    }
}
