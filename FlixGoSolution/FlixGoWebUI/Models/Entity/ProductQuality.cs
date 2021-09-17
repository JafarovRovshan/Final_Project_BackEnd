using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.Entity
{
    public class ProductQuality:BaseEntity
    {
        public int ProductId { get; set; }
        public int QualityId { get; set; }
        public virtual ICollection<Product>Products { get; set; }
        public virtual ICollection<Quality>Qualities { get; set; }
    }
}
