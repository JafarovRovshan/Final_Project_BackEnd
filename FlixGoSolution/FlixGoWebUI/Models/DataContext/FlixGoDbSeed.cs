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
            }

            return app;
        }

        private static void InitCategory(FlixGoDbContext db)
        {
            if (!db.Categories.Any())
            {
                db.Categories.Add(new Category
                {
                    Name = "Movies"
                });
                db.Categories.Add(new Category
                {
                    Name = "Tv Series"
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
