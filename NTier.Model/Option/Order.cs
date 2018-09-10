using NTier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Model.Option
{
    public class Order:CoreEntity
    {
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int AppUserId { get; set; }        
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
