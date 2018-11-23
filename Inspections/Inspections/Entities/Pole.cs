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

            var poleTest = new Pole();
            poleTest.id = 0;
            poleTest.height = 25.2;
            poleTest.material = "Madeira";
            poleTest.latitude = 55.3M;
            poleTest.longitude = 99.3M;
            poleTest.boxID = 0;

            polesList.Add(poleTest);

            return polesList;
        }
    }
}
