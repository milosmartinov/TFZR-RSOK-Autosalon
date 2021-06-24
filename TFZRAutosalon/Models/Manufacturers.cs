namespace TFZRAutosalon.Models
{
    public class Manufacturers : BaseModel
    {
        public string Name { get; set; }
        public override bool IsModelValid()
        {
            throw new System.NotImplementedException();
        }
    }
}