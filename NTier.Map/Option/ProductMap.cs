using NTier.Core.Entity;
using NTier.Core.Map;
using NTier.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Map.Option
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x => x.Name).HasMaxLength(50).IsOptional();
            Property(x => x.Price).IsOptional();
            Property(x => x.UnitsInStock).IsOptional();
            Property(x => x.Quantity).IsOptional();

            HasRequired(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).WillCascadeOnDelete(true);
            HasRequired(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.BrandId).WillCascadeOnDelete(true);

            HasMany(x => x.ProductVideos).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
            HasMany(x => x.ProductImages).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
            HasMany(x => x.ProductDetails).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
            HasMany(x => x.OrderDetails).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
            HasMany(x => x.Features).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
            HasMany(x => x.Comments).WithRequired(x => x.Product).HasForeignKey(x => x.ProductId);
        }
    }
}
