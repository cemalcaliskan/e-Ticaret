using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class SubCategoryMap:CoreMap<SubCategory>
    {
        public SubCategoryMap()
        {
            ToTable("dbo.SubCategories");
            Property(x => x.Name).HasMaxLength(50).IsOptional();
            Property(x => x.Description).HasMaxLength(250).IsOptional();

            HasRequired(x => x.Category).WithMany(x => x.SubCategories).HasForeignKey(x => x.CategoryId).WillCascadeOnDelete(true);
        }
    }
}
