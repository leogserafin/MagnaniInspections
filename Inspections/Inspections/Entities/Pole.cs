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
        private CRUD crud - new CRUD();

        public static List<Pole> Poles()
        {
            var polesList = new List<Pole>();

            CRUD crud = new CRUD();
            crud.Poles.ToList()
                .ForEach(pole => polesList.Add(pole));

            return polesList;
        }

        public void InsertPole(Pole pole)
        {
            string insert = $"INSERT INTO dbo.pole(id, height, material, latitude, longitude, boxid) VALUES ({pole.id}, '{pole.height}', '{pole.material}', '{pole.latitude}', '{pole.longitude}', '{pole.boxid}')";
            crud.Database.ExecuteSqlCommand(insert);
        }

        public void RemovePole(int id)
        {
            string remove = $"DELETE from dbo.pole WHERE id = {id};";
            crud.Database.ExecuteSqlCommand(remove);                    
        }
    }
}
