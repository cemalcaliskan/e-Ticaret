using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class ProductImageMap:CoreMap<ProductImage>
    {
        public ProductImageMap()
        {
            ToTable("dbo.ProductImages");
            Property(x => x.Name).HasMaxLength(100).IsOptional();
            Property(x => x.Description).HasMaxLength(250).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);
        }
    }
}
