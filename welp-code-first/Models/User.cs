using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class User
    {
        // properties
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }

        // navigation properties
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}