using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapPhimOOSD.Models
{
    public class Customer
    {
        //Bảng Customer và Login có quan hệ 1-1. Khi tạo tài khoản login thì insert data vào Login rồi từ Key bảng Login cũng là key Customer.
        [Key]
        public Guid Id { get; set; }
        public Login idAccount { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
    }
}
