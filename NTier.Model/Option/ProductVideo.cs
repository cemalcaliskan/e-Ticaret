using NTier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Model.Option
{
    public class ProductVideo:CoreEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
