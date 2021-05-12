using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShowdeBola.Data;
using System;
using System.Linq;

namespace ShowdeBola.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new ShowdeBolaContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ShowdeBolaContext>>()))
                {
                    if(context.Movie.Any())
                    {
                        return; //BD já tem filmes cadastrados
                    }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "Velozes e Furiosos",
                            ReleaseDate = DateTime.Parse("2001-9-28"),
                            Genre = "Ação",
                            Rating = "A",
                            Price = 38M
                        },
                        new Movie
                        {
                            Title = "Escola do Rock",
                            ReleaseDate = DateTime.Parse("2004-2-13"),
                            Genre = "Comédia",
                            Rating = "A",
                            Price = 35M
                        },
                        new Movie
                        {
                            Title = "Senhor dos Anéis - Retorno do Rei",
                            ReleaseDate = DateTime.Parse("2003-12-25"),
                            Genre = "Aventura",
                            Rating = "A",
                            Price = 95M
                        },
                        new Movie
                        {
                            Title = "Star Wars: Episódio I – A Ameaça Fantasma",
                            ReleaseDate = DateTime.Parse("1999-6-24"),
                            Genre = "Aventura",
                            Rating = "B",
                            Price = 1027M
                        }
                    );
                    context.SaveChanges();

                }
        }
    }
}