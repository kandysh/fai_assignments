using System;
using System.Collections.Generic;

namespace FaiAssignments
{
    internal class Movie
    {
        public string MovieName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Movie movie &&
                   MovieName == movie.MovieName;
        }

        public override string ToString()
        {
            return $"{MovieName}";
        }
    }

    internal static class MovieDB
    {
        private static List<Movie> movies = new List<Movie>();

        internal static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        internal static void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }

        internal static void UpdateMovie(Movie movie)
        {
            if (movie != null)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i] == movie)
                    {
                        movies[i].MovieName = movie.MovieName;
                    }
                }
            }
        }

        internal static void GetAllMovies()
        {
            foreach (var movie in movies) { System.Console.WriteLine(movie); }
        }
    }

    internal static class Ass05
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add movie 2.Update Movie 3. Delete Movie 4. Get all movies");
                int choice = UIConsole.GetInteger("Enter your choice");
                switch (choice)
                {
                    case 1:
                        MovieDB.AddMovie(new Movie { MovieName = UIConsole.GetString("Enter movie name") });
                        break;

                    case 2:
                        MovieDB.UpdateMovie(new Movie { MovieName = UIConsole.GetString("Enter Movie") });
                        break;

                    case 3:
                        MovieDB.RemoveMovie(new Movie { MovieName = UIConsole.GetString("Enter Movie") });
                        break;

                    case 4:
                        MovieDB.GetAllMovies();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}