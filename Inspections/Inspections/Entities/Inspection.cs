using Inspections.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    [Table("inspection")]
    class Inspection
    {
        public int id { get; set; }
        public string bob { get; set; }
        public string polewiring { get; set; }
        public string polesituation { get; set; }
        public int poleid { get; set;}
        public DateTime date { get; set; }

        public static List<Inspection> Inspections()
        {
            var inspectionsList = new List<Inspection>();

            CRUD crud = new CRUD();
            crud.Inspections.ToList()
                .ForEach(inspection => inspectionsList.Add(inspection));

            return inspectionsList;
        }
            
          
    }
}

