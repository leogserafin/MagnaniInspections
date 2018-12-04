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
        public bool bob { get; set; }
        public bool polewiring { get; set; }
        public bool polesituation { get; set; }
        public int poleid { get; set;}
        public DateTime date { get; set; }
        private static CRUD crud = new CRUD();

        public static List<Inspection> Inspections()
        {
            var inspectionsList = new List<Inspection>();

            CRUD crud = new CRUD();
            crud.Inspections.ToList()
                .ForEach(inspection => inspectionsList.Add(inspection));

            return inspectionsList;
        }
            
         public void InsertInspection(Inspection inspection)
        {
            string insert = $"INSERT INTO dbo.inspection(id, date, polesituation, bob, polewiring, poleid) VALUES ({inspection.id}, '{inspection.date}', '{inspection.polesituation}', '{inspection.bob}', '{inspection.polewiring}', '{inspection.poleid}')";
            crud.Database.ExecuteSqlCommand(insert);
        }

        public void Remove(int id)
        {
            string delete = $"DELETE FROM dbo.inspection WHERE id = {id};";
            crud.Database.ExecuteSqlCommand(delete);
        }

        internal bool existsId(int id)
        {
            foreach (var inspection in Inspections())
            {
                if (id == inspection.id)
                    return true;
            }
            return false;
        }
    }
}

