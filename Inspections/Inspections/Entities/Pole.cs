using Inspections.DataBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Inspections.Entities
{
    [Table("Pole")]
    class Pole
    {
        public int Id { get; set; }
        public double Height { get; set; }
        public string Material { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int BoxID { get; set; }

        public static List<Pole> Poles()
        {
            var polesList = new List<Pole>();

            DAL dal = new DAL();
            dal.Poles.ToList()
                .ForEach(pole => polesList.Add(pole));

            return polesList;
        }
    }
}
