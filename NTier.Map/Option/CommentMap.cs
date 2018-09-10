using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Description).HasMaxLength(2000).IsOptional();

            HasRequired(x => x.Product).WithMany(x => x.Comments).HasForeignKey(x => x.ProductId).WillCascadeOnDelete(true);
            HasRequired(x => x.AppUser).WithMany(x => x.Comments).HasForeignKey(x => x.AppUserId).WillCascadeOnDelete(true);
        }
    }
}
