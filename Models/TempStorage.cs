using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public static class TempStorage
    {
        // list of Films that persist in memory
        private static List<Film> films = new List<Film>();

        // Getter property for the list of Films
        public static IEnumerable<Film> Films => films;

        // Adds a Film to films
        /// <summary>
        /// Adds a Film to TempStorage's list of Films.
        /// </summary>
        /// <param name="film">The Film instance to add.</param>
        public static void AddFilm(Film film)
        {
            films.Add(film);
        }
    }
}
