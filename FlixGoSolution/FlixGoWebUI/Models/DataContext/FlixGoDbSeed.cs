using FlixGoWebUI.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.DataContext
{
    public static class FlixGoDbSeed
    {
        public static IApplicationBuilder Seed(this IApplicationBuilder app) 
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<FlixGoDbContext>();
               
                db.Database.Migrate();

                InitCategory(db);
                InitCountry(db);
                 InitGenre(db);
                InitProductImage(db);
                 InitProduct(db);
            }

            return app;
        }

        private static void InitProduct(FlixGoDbContext db)
        {

            if (!db.Products.Any())
            {
                //ProductImage productImage = new ProductImage
                //{
                //    Id = 1,
                //    ImagePath = "cover.jpg"
                //};
                //ProductImage productImage2 = new ProductImage
                //{
                //    Id = 2,
                //    ImagePath = "cover2.jpg"
                //};

                var category = db.Categories.FirstOrDefault();
                var genre = db.Genres.FirstOrDefault();
                var country = db.Countries.FirstOrDefault();
                if (category != null && genre != null)
                {

                    Product product = new Product
                    {
                        Name = "I Dream in Another Language",
                        Genre = genre,
                        Country = country,
                        Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                        Duration = 120,
                        ReleaseDate = 2017,
                        Category = category,
                        ProductImageId = 1
                    };

                    Product product2 = new Product
                    {
                        Name = "Lucy",
                        Genre = genre,
                        Country = country,
                        Description = "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on",
                        Duration = 90,
                        ReleaseDate = 2018,
                        Category = category,
                        ProductImageId = 2
                    };

                    //db.ProductImages.Add(productImage);
                    //db.ProductImages.Add(productImage2);
                    db.Products.Add(product);
                    db.Products.Add(product2);


                    db.SaveChanges();
                }

            }
        }
        private static void InitProductImage(FlixGoDbContext db)
        {
            if (!db.ProductImages.Any())
            {
                db.ProductImages.Add(new ProductImage
                {
                    //Id = 1,   identity columndu-deye ehtiyyac yoxdu
                    ImagePath = "cover.jpg"
                });
                db.ProductImages.Add(new ProductImage
                {
                    ImagePath = "cover2.jpg"
                });
                db.ProductImages.Add(new ProductImage
                {
                    ImagePath = "cover3.jpg"
                });
                db.SaveChanges();
            }
        }

        private static void InitGenre(FlixGoDbContext db)
        {
            if (!db.Genres.Any())
            {
                db.Genres.Add(new Genre
                {
                    Name = "Comedy"
                });
                db.Genres.Add(new Genre
                {
                    Name = "Drama"
                });
                db.Genres.Add(new Genre
                {
                    Name = "Horror"
                });
                db.SaveChanges();
            }
        }

        private static void InitCountry(FlixGoDbContext db)
        {
            if (!db.Countries.Any())
            {
                db.Countries.Add(new Country
                {
                    Name = "USA"
                });
                db.Countries.Add(new Country
                {
                    Name = "Canada"
                });
                db.Countries.Add(new Country
                {
                    Name = "Russian"
                });
                db.SaveChanges();
            }
        }

        private static void InitCategory(FlixGoDbContext db)
        {
            if (!db.Categories.Any())
            {
                db.Categories.Add(new Category
                {
                    Name = "Tv Series"
                });
                db.Categories.Add(new Category
                {
                    Name = "Movies"
                });
                db.Categories.Add(new Category
                {
                    Name = "Cartoons"
                });


                db.SaveChanges();//yoxlayim birde
            }
        }

    }
}
