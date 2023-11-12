using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Driver
    {
        [Key]

        public int DriverID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(20)]
        public string DriverName { get; set; }

        [StringLength(30)]
        public string DriverEmail { get; set; }

        public string DriverImage { get; set; }

        public bool DriverStatus { get; set; }
    }
}
