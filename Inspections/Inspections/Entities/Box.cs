using Inspections.DataBase;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspections.Entities
{
    [Table("box")]
    class Box
    {
        public int id { get; set; }
        public string boxtype { get; set; }
        public int watts { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        private static CRUD crud = new CRUD();

        public static List<Box> Boxes()
        {
            var boxesList = new List<Box>();

            crud.Boxes.ToList()
                .ForEach(box => boxesList.Add(box));

            return boxesList;
        }

        public string GetBoxType()
        {
            return boxtype == "E" ? "Externa" : "Subterrânea";
        }

        public void InsertBox(Box box)
        {
            string insert = $"INSERT INTO dbo.box(id, boxtype, watts, latitude, longitude) VALUES ({box.id}, '{box.boxtype}', {box.watts}, '{box.latitude}', '{box.longitude}')";
            crud.Database.ExecuteSqlCommand(insert);
        }

        public void Remove(int id)
        {
            string delete = $"DELETE from dbo.box WHERE id = {id};";
            crud.Database.ExecuteSqlCommand(delete);
        }

        internal bool existsId(int id)
        {
            foreach (var box in Boxes())
            {
                if (id == box.id)
                    return true;
            }
            return false;
        }
    }
}
