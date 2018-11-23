using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    class Pole
    {
        public int id { get; set; }
        public double height { get; set; }
        public string material { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int boxID { get; set; }

        public static List<Pole> Poles()
       {
            var polesList = new List<Pole>();

            var pole1 = new Pole();
            pole1.id = 0;
            pole1.height = 25.2;
            pole1.material = "Madeira";
            pole1.latitude = 55.3M;
            pole1.longitude = 99.3M;
            pole1.boxID = 0;

            polesList.Add(pole1);

            return polesList;
        }

    }
}
