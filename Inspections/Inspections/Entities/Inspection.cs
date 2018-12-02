using Inspections.DataBase;
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
        public int Id { get; set; }
        public string Bob { get; set; }
        public string PoleWiring { get; set; }
        public string PoleSituation { get; set; }
        public int PoleID { get; set;}
        public DateTime Date { get; set; }

        public static List<Inspection> Inspections()
        {
            var inspectionsList = new List<Inspection>();

            DAL dal = new DAL();
            dal.Inspections.ToList()
                .ForEach(inspection => inspectionsList.Add(inspection));

            return inspectionsList;
        }
            
          
    }
}

