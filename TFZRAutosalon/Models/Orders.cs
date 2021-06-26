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
        public virtual IdentityUser User { get; set; }
        [ForeignKey("FK_Cars_Orders")]
        public virtual Cars Car { get; set; }

        [Column("FK_Users_Orders")]
        public Guid UserId { get; set; }
        [Column("FK_Cars_Orders")]
        public int CarId { get; set; }

        public int Status { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public override bool IsModelValid()
        {
            throw new NotImplementedException();
        }
    }
}
