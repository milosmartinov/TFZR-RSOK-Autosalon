using System.ComponentModel.DataAnnotations.Schema;

namespace TFZRAutosalon.Models
{
    public class CarModels : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("FK_Categorizes_CarModels")]
        public Categorizes Category { get; set; }

        [ForeignKey("FK_Manufacturer_CarModels")]
        public Manufacturers Manufacturer { get; set; }
    }
}