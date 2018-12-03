using Inspections.DataBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Inspections.Entities
{
    [Table("pole")]
    class Pole
    {
        public int id { get; set; }
        public double height { get; set; }
        public string material { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int boxid { get; set; }

        public static List<Pole> Poles()
        {
            var polesList = new List<Pole>();

            CRUD crud = new CRUD();
            crud.Poles.ToList()
                .ForEach(pole => polesList.Add(pole));

            return polesList;
        }
    }
}
