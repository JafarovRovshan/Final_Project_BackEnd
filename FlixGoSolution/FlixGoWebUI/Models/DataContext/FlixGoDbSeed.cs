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
                        ImagePath = "cover1.jpg"
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
                        ImagePath = "cover2.jpg"
                    };
                    Product product3 = new Product
                    {
                        Name = "13 Hours: The Secret Soldiers of Benghazi",
                        Genre = genre,
                        Country = country,
                        Description = "The film follows six members of Annex Security Team who fought to defend the American diplomatic compound in Benghazi, Libya after waves of attacks by militants on September 11, 2012. ... Known colloquially as 'the Benghazi movie', the film was released on January 15, 2016, by Paramount Pictures.",
                        Duration = 144,
                        ReleaseDate = 2016,
                        Category = category,
                        ImagePath = "cover3.jpg"
                    };

                    Product product4 = new Product
                    {
                        Name = "Avengers: Infinity War",
                        Genre = genre,
                        Country = country,
                        Description = "Avengers: Infinity War is a 2018 American superhero film based on the Marvel Comics superhero team the Avengers. ... In the film, the Avengers and the Guardians of the Galaxy attempt to prevent Thanos from collecting the six all-powerful Infinity Stones as part of his quest to kill half of all life in the universe.",
                        Duration = 149,
                        ReleaseDate = 2018,
                        Category = category,
                        ImagePath = "cover4.jpg"
                    };
                    Product product5 = new Product
                    {
                        Name = "We're the Millers",
                        Genre = genre,
                        Country = country,
                        Description = "The plot follows a small-time pot dealer (Sudeikis) who convinces his neighbors to help him by pretending to be his family, in order to smuggle drugs from Mexico into the United States. The film was released on August 7, 2013, by New Line Cinema through Warner Bros. Pictures.",
                        Duration = 118,
                        ReleaseDate = 2013,
                        Category = category,
                        ImagePath = "cover5.jpg"
                    };

                    Product product6 = new Product
                    {
                        Name = "Coffee & Kareem",
                        Genre = genre,
                        Country = country,
                        Description = "It stars Ed Helms, Terrence Little Gardenhigh, Betty Gilpin, RonReaco Lee, Andrew Bachelor, David Alan Grier and Taraji P. Henson, and follows a bumbling Detroit cop who must rescue his girlfriend and her 12-year-old son from gangsters after the boy witnesses a murder.",
                        Duration = 88,
                        ReleaseDate = 2020,
                        Category = category,
                        ImagePath = "cover6.jpg"
                    };

                    db.Products.Add(product);
                    db.Products.Add(product2);
                    db.Products.Add(product3);
                    db.Products.Add(product4);
                    db.Products.Add(product5);
                    db.Products.Add(product6);

                    db.SaveChanges();
                }

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
