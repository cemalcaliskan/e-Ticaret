
using NTier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Model.Option
{
    public class ProductDetail:CoreEntity
    {
        public string Description { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
