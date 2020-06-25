using System.Collections.Generic;
using System.Linq;

namespace MoviappUygulaması.Models
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {ID = 1, Name = "Movie 1", Image = "1.jpeg"},
                new Movie() {ID = 2, Name = "Movie 2", Image = "2.jpeg"},
                new Movie() {ID = 3, Name = "Movie 3", Image = "3.jpeg"},
                new Movie() {ID = 4, Name = "Movie 4", Image = "1.jpeg"},
                new Movie() {ID = 5, Name = "Movie 5", Image = "5.jpg"},
                new Movie() {ID = 6, Name = "Movie 6", Image = "6.jpg"},
                new Movie() {ID = 7, Name = "Movie 7", Image = "7.jpg"},
                new Movie() {ID = 8, Name = "Movie 8", Image = "8.jpg"},
                new Movie() {ID = 9, Name = "Movie 9", Image = "9.jpg"},
                new Movie() {ID = 7, Name = "Movie 7", Image = "7.jpg"},
                new Movie() {ID = 8, Name = "Movie 8", Image = "8.jpg"},
                new Movie() {ID = 9, Name = "Movie 9", Image = "9.jpg"}, 
                new Movie() {ID = 7, Name = "Movie 7", Image = "7.jpg"},
                new Movie() {ID = 8, Name = "Movie 8", Image = "8.jpg"},
                new Movie() {ID = 9, Name = "Movie 9", Image = "9.jpg"},
            };

        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.ID == id);
        }
            
        
    }
}