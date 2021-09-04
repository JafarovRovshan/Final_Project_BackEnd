using FlixGoWebUI.Models.Entity;
using System.Collections.Generic;

namespace FlixGoWebUI.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
