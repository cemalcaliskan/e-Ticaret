using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasMaxLength(50).IsOptional();
            Property(x => x.Description).HasMaxLength(200).IsOptional();

            HasMany(x => x.Products).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryId);
            HasMany(x => x.SubCategories).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
