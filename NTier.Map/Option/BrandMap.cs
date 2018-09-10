using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class BrandMap:CoreMap<Brand>
    {
        public BrandMap()
        {
            ToTable("dbo.Brands");
            Property(x => x.Name).HasMaxLength(50).IsOptional();
            Property(x => x.Description).HasMaxLength(150).IsOptional();
            Property(x => x.ImagePath).HasMaxLength(50).IsOptional();

            HasMany(x => x.Products).WithRequired(x => x.Brand).HasForeignKey(x => x.BrandId);
            
        }
    }
}
