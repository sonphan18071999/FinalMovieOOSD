using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapPhimOOSD.Models
{
    public class Login
    {
        [Key]
        public Guid Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string sessionId { get; set; }

    }
}
