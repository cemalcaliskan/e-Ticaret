using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class OrderMap:CoreMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
            Property(x => x.TotalAmount).IsOptional();
            Property(x => x.OrderDate).HasColumnType("datetime2").IsOptional();

            HasRequired(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.AppUserId).WillCascadeOnDelete(true);

            HasMany(x => x.OrderDetails).WithRequired(x => x.Order).HasForeignKey(x => x.OrderId);

        }
    }
}
