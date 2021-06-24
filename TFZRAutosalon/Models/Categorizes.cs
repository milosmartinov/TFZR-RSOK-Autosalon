namespace TFZRAutosalon.Models
{
    public class Categorizes : BaseModel
    {
        public string Name { get; set; }
        public override bool IsModelValid()
        {
            throw new System.NotImplementedException();
        }
    }
}