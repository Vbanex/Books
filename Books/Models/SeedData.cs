using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>())){
               
                if (context.Book.Any())
                {
                    return;
                }
                
                context.Book.AddRange(
                    new Book
                    {
                      Author = "Olabamiji Omolade",
                      Title = "Introduction To Programming",
                      Genre = "Education",
                      ReleasedDate = DateTime.Parse("2020-02-15"),
                      Price = 150.00M
                    },

                      new Book
                      {
                          Author = "Olabamiji Omolade",
                          Title = "Object Oriented Programming",
                          Genre = "Education",
                          ReleasedDate = DateTime.Parse("2021-07-05"),
                          Price = 200.00M
                      },

                        new Book
                        {
                            Author = "Olabamiji Omolade",
                            Title = "Web Programming",
                            Genre = "Education",
                            ReleasedDate = DateTime.Parse("2022-01-11"),
                            Price = 180.00M
                        }

                    );
                context.SaveChanges();
            }
        }
    }
}
