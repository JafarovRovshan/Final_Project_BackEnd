
using FlixGoWebUI.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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
                InitGenre(db);
                InitCountry(db);
                InitQuality(db);
                InitReleaseYear(db);
                InitProduct(db);
                InitProductGenre(db);
                InitProductQuality(db);
                InitProductReleaseYear(db);

            }

            return app;
        }

        private static void InitProductReleaseYear(FlixGoDbContext db)
        {
            if (!db.ProductReleaseYears.Any())
            {
                db.ProductReleaseYears.Add(new ProductReleaseYear
                {
                    ReleaseYearId = 2,
                    ProductId = 3
                });
                db.SaveChanges();
            }
        }

        private static void InitProductQuality(FlixGoDbContext db)
        {
            if (!db.ProductQualities.Any())
            {
                db.ProductQualities.Add(new ProductQuality
                {
                    QualityId = 1,
                    ProductId = 2
                });
                db.SaveChanges();
            }
        }

        //test eliyirik sencani ishle))
        private static void InitProductGenre(FlixGoDbContext db)
        {
            if (!db.ProductGenres.Any())
            {
                db.ProductGenres.Add(new ProductGenre
                {
                    GenreId=1,
                    ProductId=1
                });
                db.SaveChanges();
            }
        }

        private static void InitProduct(FlixGoDbContext db)
        {
            if (!db.Products.Any())
            {
                var category = db.Categories.FirstOrDefault();
                var country = db.Countries.FirstOrDefault();
                var genre = db.Genres.FirstOrDefault();
                var quality = db.Qualities.FirstOrDefault();
                var releaseYear = db.ReleaseYears.FirstOrDefault();

                if (category!=null && country!=null && genre!=null && quality!=null &&releaseYear!=null)
                {
                    Product product = new Product
                    {
                        Name= "Benched",
                        Category=category,
                        Description= "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters",
                        Country=country,
                        Genre=genre,
                        Quality=quality,
                        ReleaseYear=releaseYear


                    };

                    product.Images = new List<ProductImage>();
                    product.Images.Add(new ProductImage
                    {
                        ImagePath="cover1.jpg",
                        IsMain=true
                    });
                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "project-1.jpg",
                        IsMain = false
                    });
                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "project-2.jpg",
                        IsMain = false
                    });

                    //2-ci mehsul
                    Product product2 = new Product
                    {
                        Name = "Lucy",
                        Category = category,
                        Description = "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, ",
                        Country = country,
                        Genre = genre,
                        Quality = quality,
                        ReleaseYear = releaseYear


                    };

                    product2.Images = new List<ProductImage>();
                    product2.Images.Add(new ProductImage
                    {
                        ImagePath = "cover2.jpg",
                        IsMain = true
                    });
                    product2.Images.Add(new ProductImage
                    {
                        ImagePath = "project-3.jpg",
                        IsMain = false
                    });
                    product2.Images.Add(new ProductImage
                    {
                        ImagePath = "project-4.jpg",
                        IsMain = false
                    });

                    //3-cu mehsul
                    Product product3 = new Product
                    {
                        Name = "Infinite",
                        Category = category,
                        Description = "Evan Michaels suffers from an unusual ailment: he remembers in detail everything that happened",
                        Country = country,
                        Genre = genre,
                        Quality = quality,
                        ReleaseYear = releaseYear

                    };

                    product3.Images = new List<ProductImage>();
                    product3.Images.Add(new ProductImage
                    {
                        ImagePath = "cover3.jpg",
                        IsMain = true
                    });
                    product3.Images.Add(new ProductImage
                    {
                        ImagePath = "project-5.jpg",
                        IsMain = false
                    });
                    product3.Images.Add(new ProductImage
                    {
                        ImagePath = "project-6.jpg",
                        IsMain = false
                    });

                    db.Products.Add(product);
                    db.Products.Add(product2);
                    db.Products.Add(product3);
                   
                    db.SaveChanges();
                }


               
            }
        }

        private static void InitReleaseYear(FlixGoDbContext db)
        {
            if (!db.ReleaseYears.Any())
            {
                db.ReleaseYears.Add(new ReleaseYear
                {
                    Year = 2000
                });
                db.ReleaseYears.Add(new ReleaseYear
                {
                    Year = 2005
                });
                db.ReleaseYears.Add(new ReleaseYear
                {
                    Year = 2010
                });
                db.SaveChanges();
            }
        }

        private static void InitQuality(FlixGoDbContext db)
        {
            if (!db.Qualities.Any())
            {
                db.Qualities.Add(new Quality
                {
                    Name = "HD 1080"
                });
                db.Qualities.Add(new Quality
                {
                    Name = "HD 720"
                });
                db.Qualities.Add(new Quality
                {
                    Name = "DVD"
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
                    Name = "Spain"
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
                    Name = "Action/Adventure"
                });
                db.Genres.Add(new Genre
                {
                    Name = "Animals"
                });
                db.Genres.Add(new Genre
                {
                    Name = "Animation"
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
                    Name="Serial"
                });
                db.Categories.Add(new Category
                {
                    Name = "Film"
                });
                db.Categories.Add(new Category
                {
                    Name = "Cizgi Film"
                });
                db.SaveChanges();
            }
        }
    }
}
