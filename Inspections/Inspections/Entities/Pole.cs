using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

            var poleTest = new Pole
            {
                Id = 0,
                Height = 25.2,
                Material = "Madeira",
                Latitude = 55.3M,
                Longitude = 99.3M,
                BoxID = 0
            };

            polesList.Add(poleTest);

            return polesList;
        }
    }
}
