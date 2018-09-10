using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class OrderDetailMap:CoreMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("dbo.OrderDetails");
            Property(x => x.UnitPrice).IsOptional();
            Property(x => x.Quantity).IsOptional();
            Property(x => x.Discount).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);
            HasRequired(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId).WillCascadeOnDelete(true);

        }
    }
}
