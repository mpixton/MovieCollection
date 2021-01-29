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
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required!")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required!")]
        public RatingTypes Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be less than 25 characters!")]
        public string Notes { get; set; }
    }
}
