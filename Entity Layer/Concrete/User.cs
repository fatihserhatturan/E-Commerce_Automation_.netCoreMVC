using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string UserEmail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public string UserImage { get; set; }
    }
}
