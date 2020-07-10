using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapPhimOOSD.Models
{
    public class Trailer
    {
        [Key]
        public Guid Id { get; set; }
        public Movie movie { get; set; }
        public string linkTrailer { get; set; }
    }
}
