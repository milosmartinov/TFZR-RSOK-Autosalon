using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TFZRAutosalon.Models
{
    public class Cars : BaseModel
    {
        [ForeignKey("FK_CarModels_Cars")]
        public CarModels CarModel { get; set; }
        [ForeignKey("FK_CarManufacturers_Cars")]
        public Manufacturers Manufacturer { get; set; }

        public Categorizes Categoriz { get; set; }
        public string Description { get; set; }
        public long HorsePower { get; set; }
        public long Torque { get; set; }
        public int NumberOfDoors { get; set; }
        public override bool IsModelValid()
        {
            throw new NotImplementedException();
        }
    }
}
