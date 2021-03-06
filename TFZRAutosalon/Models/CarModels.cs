using System.ComponentModel.DataAnnotations.Schema;

namespace TFZRAutosalon.Models
{
    public class CarModels : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("FK_Categorizes_CarModels")]
        public virtual Categorizes Category { get; set; }

        [ForeignKey("FK_Manufacturer_CarModels")]
        public virtual Manufacturers Manufacturer { get; set; }

        public override bool IsModelValid()
        {
            throw new System.NotImplementedException();
        }
    }
}