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
        PG13 = 2,
        R = 3
    }
    public class Film
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public RatingTypes Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }
    }
}
