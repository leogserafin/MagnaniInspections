using Inspections.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspections.Entities
{
    [Table("Box")]
    class Box
    {
        public int Id { get; set; }
        public string BoxType { get; set; }
        public int Watts { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public static List<Box> Boxes()
        {
            var boxesList = new List<Box>();

            DAL dal = new DAL();
            dal.Boxes.ToList()
                .ForEach(box => boxesList.Add(box));

            return boxesList;
        }

        public string GetBoxType()
        {
            return BoxType == "E" ? "Externa" : "Subterrânea";
        }

    }
}
