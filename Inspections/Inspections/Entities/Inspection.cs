using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    class Inspection
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string bob { get; set; }
        public string poleWiring { get; set; }
        public string poleSituation { get; set; }

        public static List<Inspection> Inspections()
        {
            var inspectionsList = new List<Inspection>();

            var inspectionTest = new Inspection();
            inspectionTest.id = 0;
            inspectionTest.date = new DateTime(2018, 2, 15);
            inspectionTest.bob = "Uma bosta";
            inspectionTest.poleWiring = "Caindo tudo";
            inspectionTest.poleSituation = "Deprimente";

            inspectionsList.Add(inspectionTest);

            return inspectionsList;
        }
    }
}
