using FlixGoWebUI.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FlixGoWebUI.Models.DataContext
{
    public static class FlixGoDbSeed
    {
        public static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
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

                var category = db.Categories.FirstOrDefault();
                var genre = db.Genres.FirstOrDefault();
                var country = db.Countries.FirstOrDefault();
                if (category != null && genre != null)
                {

                    Product product = new Product
                    {
                        Name = "Joker",
                        Genre = genre,
                        Country = country,
                        Description = "Set in 1981, it follows Arthur Fleck, a failed clown and stand-up comedian whose descent into insanity and nihilism inspires a violent counter-cultural revolution against the wealthy in a decaying Gotham City.",
                        Duration = 122,
                        ReleaseDate = 2019,
                        Category = category,
                        ProductImageId = 1,
                        ImagePath = "cover5.jpg"
                    };

                    Product product2 = new Product
                    {
                        Name = "Lucy",
                        Genre = genre,
                        Country = country,
                        Description = "Lucy is a smart, college student who finds herself in a horrific drug and human trafficking situation where her brain is permanently altered by an illegal new drug that gets accidentally ingested during her captivity.",
                        Duration = 90,
                        ReleaseDate = 2014,
                        Category = category,
                        ProductImageId = 2,
                        ImagePath = "cover7.jpg"
                    };

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


                db.SaveChanges();
            }
        }

    }
}
