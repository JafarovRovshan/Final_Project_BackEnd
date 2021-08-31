using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int ProductImageId { get; set; }
        public virtual ProductImage ProductImage { get; set; }
        public string Description { get; set; }
    }
}
