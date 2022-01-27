using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //leave blank for now
        }
    
        public DbSet<FormResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    MovieId = 1,
                    Category = "RomCom",
                    Title = "13 Going on 30",
                    Year = "2004",
                    Director = "Gary Winick",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Cami",
                    Notes = "My favorite romcom"
                },
                new FormResponse
                {
                    MovieId = 2,
                    Category = "Superhero",
                    Title = "The Avengers",
                    Year = "2012",
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Spencer",
                    Notes = "So funny"
                },
                new FormResponse
                {
                    MovieId = 3,
                    Category = "Disney",
                    Title = "Tangled",
                    Year = "2010",
                    Director = "Nathan Greno",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Elena",
                    Notes = "Best Princess Movie"
                }
               );
        }
    }
}
