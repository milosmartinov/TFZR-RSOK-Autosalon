using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TFZRAutosalon.Models
{
    public class Orders : BaseModel
    {
        [ForeignKey("FK_Users_Orders")]
        public IdentityUser User { get; set; }
        [ForeignKey("FK_Cars_Orders")]
        public Cars Car { get; set; }

        public int Status { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public override bool IsModelValid()
        {
            throw new NotImplementedException();
        }
    }
}
