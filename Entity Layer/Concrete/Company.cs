using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [StringLength(20)]
        public string CompanyName { get; set; }

        [StringLength(20)]
        public string CompanyImage { get; set; }


        [StringLength(200)]
        public string CompanyDescription { get; set; }


        public int CompanyRating { get; set; }

        [StringLength(50)]
        public string CompanyEmail { get; set; }

        [StringLength(20)]
        public string CompanyPassword { get; set;}
    }
}
