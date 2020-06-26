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
                new Movie()
                {
                    ID = 1, Name = "Movie 1", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "1.jpeg"
                },
                new Movie()
                {
                    ID = 2, Name = "Movie 2", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "2.jpeg"
                },
                new Movie()
                {
                    ID = 3, Name = "Movie 3", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "3.jpeg"
                },
                new Movie()
                {
                    ID = 4, Name = "Movie 4", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "1.jpeg"
                },
                new Movie()
                {
                    ID = 5, Name = "Movie 5", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "5.jpg"
                },
                new Movie()
                {
                    ID = 6, Name = "Movie 6", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "6.jpg"
                },
                new Movie()
                {
                    ID = 7, Name = "Movie 7", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "7.jpg"
                },
                new Movie()
                {
                    ID = 8, Name = "Movie 8", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "8.jpg"
                },
                new Movie()
                {
                    ID = 9, Name = "Movie 9", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "9.jpg"
                },
                new Movie()
                {
                    ID = 7, Name = "Movie 7", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "7.jpg"
                },
                new Movie()
                {
                    ID = 8, Name = "Movie 8", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "8.jpg"
                },
                new Movie()
                {
                    ID = 9, Name = "Movie 9", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "9.jpg"
                },
                new Movie()
                {
                    ID = 7, Name = "Movie 7", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "7.jpg"
                },
                new Movie()
                {
                    ID = 8, Name = "Movie 8", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "8.jpg"
                },
                new Movie()
                {
                    ID = 9, Name = "Movie 9", Descireption = "Abdulaziz Güneş Amcası onu Çok seviyor", Image = "9.jpg"
                },
            };
        }

        public static List<Movie> Movies
        {
            get { return _movies; }
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