using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.Entity
{
    public class ProductReleaseYear : BaseEntity
    {
        public int ProductId { get; set; }
        public int ReleaseYearId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ReleaseYear> ReleaseYears { get; set; }
    }
}
