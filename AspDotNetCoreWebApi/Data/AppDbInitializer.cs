using AspDotNetCoreWebApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspDotNetCoreWebApi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            using(serviceScope)
            {
               var context= serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Book()
                        {
                            Title = "1st Book Title",
                            Description = "1st Book Description",
                            IsRead = true,
                            DateRead = DateTime.Today.AddDays(-10),
                            Rate = 7,
                            Genre = "Sourav",
                            Author = "Hasan",
                            CoverUrl = "Bapi Bari Ja",
                            DateAdded = DateTime.Today
                        },
                        new Book()
                        {
                            Title = "2nd Book Title",
                            Description = "2nd Book Description",
                            IsRead = true,
                            DateRead = DateTime.Today.AddDays(-20),
                            Rate = 7,
                            Genre="Sourav",
                            Author="Hasan",
                            CoverUrl="Bapi Bari Ja",
                            DateAdded=DateTime.Today.AddDays(20),
                        }) ;
                    context.SaveChanges();
                }
            }
        }
    }
}
