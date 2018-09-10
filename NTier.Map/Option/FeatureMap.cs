using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class FeatureMap:CoreMap<Feature>
    {
        public FeatureMap()
        {
            ToTable("dbo.Features");
            Property(x => x.ProductDetail).HasMaxLength(220).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.Features).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);
        }
    }
}
