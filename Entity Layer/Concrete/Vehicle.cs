using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Vehicle
    {
        [Key]

        public int VehicleID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(20)]
        public string VehicleModel { get; set; }

        public string VehicleImage { get; set;}

        [StringLength(20)]
        public string VehicleLicense { get; set;}

        public bool VehicleStatus { get; set; }
    }
}
