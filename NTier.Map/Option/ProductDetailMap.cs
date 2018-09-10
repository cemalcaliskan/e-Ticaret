using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class ProductDetailMap:CoreMap<ProductDetail>
    {
        public ProductDetailMap()
        {
            ToTable("dbo.ProductDetails");
            Property(x => x.Description).HasMaxLength(250).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);

        }
    }
}
