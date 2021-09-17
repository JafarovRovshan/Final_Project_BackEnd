using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.Entity
{
    public class ProductGenre : BaseEntity
    {
        public int GenreId { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
