using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            Assignment3DbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<Assignment3DbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        Category = "Action/Adventure",
                        Name = "Avengers, The",
                        Year = 2012,
                        Director = "Joss Whedon",
                        Rating = "R",
                        Edited = false,
                        LentTo = "",
                        Notes = "",
                    },

                    new Movie
                    {
                        Category = "Action/Adventure",
                        Name = "Batman",
                        Year = 1989,
                        Director = "Tim Burton",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "",
                    },

                    new Movie
                    {
                        Category = "Action/Adventure",
                        Name = "Batman & Robin",
                        Year = 1997,
                        Director = "Joel Schumacher",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "",
                    },

                    new Movie
                    {
                        Category = "Action/Adventure",
                        Name = "Batman Begins",
                        Year = 2005,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "",
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
