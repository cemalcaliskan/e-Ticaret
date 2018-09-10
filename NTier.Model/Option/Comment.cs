using NTier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Model.Option
{
    public class Comment:CoreEntity
    {
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int AppUserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
