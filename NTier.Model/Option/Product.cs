using NTier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Model.Option
{
    public class Product:CoreEntity
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public string Quantity { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<ProductVideo> ProductVideos { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<Feature> Features { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
