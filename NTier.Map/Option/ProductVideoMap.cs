using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class ProductVideoMap:CoreMap<ProductVideo>
    {
        public ProductVideoMap()
        {
            ToTable("dbo.ProductVideos");
            Property(x => x.Name).HasMaxLength(100).IsOptional();
            Property(x => x.Description).HasMaxLength(250).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.ProductVideos).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);
        }
    }
}
