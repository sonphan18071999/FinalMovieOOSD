using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace RapPhimOOSD.Models
{
    public class Movie
    {
        [Key]
        public Guid id { get; set; }
        public string movieName { get; set; }
        public string author { get; set; }
        public string typeMovie { get; set; }
        public DateTime yearPublish { get; set; }
        public float duration { get; set; }
        public float movieRating { get; set; }
        public string poster { get; set; }
        public Trailer trailerLink { get; set; }

    }
}
