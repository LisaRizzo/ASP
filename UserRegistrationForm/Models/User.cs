using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationForm.Models
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Color { get; set; }
        public string Animal { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

    }

}