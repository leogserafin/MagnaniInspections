using Inspections.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Inspections.Entities
{
    [Table("pole")]
    class Pole
    {
        public int id { get; set; }
        public int height { get; set; }
        public string material { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int boxid { get; set; }
        private CRUD crud = new CRUD();

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

        public void Remove(int id)
        {
            string delete = $"DELETE FROM dbo.pole WHERE id = {id};";
            crud.Database.ExecuteSqlCommand(delete);                    
        }

        internal bool existsId(int id)
        {
            foreach (var pole in Poles())
            {
                if (id == pole.id)
                    return true;
            }
            return false;
        }

        internal object GetMaterial()
        {
            return material == "F" ? "Concreto" : "Ferro";
        }
    }
}
