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
        public int GenreId { get; set; }
        public virtual Genre  Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int ProductImageId { get; set; }
        public  ProductImage ProductImage { get; set; }
        public string Description { get; set; }
    }
}
