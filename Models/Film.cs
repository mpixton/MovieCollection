using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Models
{
    public enum RatingTypes
    {
        G = 0,
        PG = 1,
        [Display(Name = "PG-13")]
        PG13 = 2,
        R = 3
    }
    public class Film
    {
        /// <summary>
        /// Title of the Film
        /// </summary>
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }

        /// <summary>
        /// Year the Film was published
        /// </summary>
        [Required(ErrorMessage = "Year is required!")]
        public int Year { get; set; }

        /// <summary>
        /// Director of the Film
        /// </summary>
        [Required(ErrorMessage = "Director is required!")]
        public string Director { get; set; }

        /// <summary>
        /// Rating of the Film
        /// </summary>
        [Required(ErrorMessage = "Rating is required!")]
        public RatingTypes Rating { get; set; }

        /// <summary>
        /// If the Film has been edited
        /// </summary>
        public bool Edited { get; set; }

        /// <summary>
        /// Name of the person the Film is currrently lent to
        /// </summary>
        [Display(Name = "Lent To")]
        public string LentTo { get; set; }

        /// <summary>
        /// Notes about the Film
        /// </summary>
        [StringLength(25, ErrorMessage = "Notes must be less than 25 characters!")]
        public string Notes { get; set; }
    }
}
