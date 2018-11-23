using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    class Box
    {
        public int id { get; set; }
        public string type { get; set; }
        public int watts { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }

        public static List<Box> Boxes()
        {
            var boxesList = new List<Box>();

            var boxTest = new Box();
            boxTest.id = 0;
            boxTest.type = "Externa";
            boxTest.watts = 9001;
            boxTest.latitude = 12.2M;
            boxTest.longitude = 54.1M;

            boxesList.Add(boxTest);

            return boxesList;
        }
    }
}
