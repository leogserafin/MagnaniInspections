using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    [Table("Inspection")]
    class Inspection
    {
        public int id { get; set; }
        public string bob { get; set; }
        public string poleWiring { get; set; }
        public string poleSituation { get; set; }
        public int poleID { get; set;}
        public DateTime date { get; set; }

        public static List<Inspection> Inspections()
        {
            var inspectionsList = new List<Inspection>();

            Inspection inspectionTest = new Inspection
            {
                id = 0,
                date = new DateTime(2018, 2, 15),
                bob = "Uma bosta",
                poleWiring = "Caindo tudo",
                poleSituation = "Deprimente"
            };

            inspectionsList.Add(inspectionTest);

            return inspectionsList;
        }
    }
}
