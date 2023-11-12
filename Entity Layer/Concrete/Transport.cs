using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Transport
    {
        [Key]
        public int TransportID { get; set; }
       
        public int UserID { get; set; }

        public int CompanyID { get; set; }
        
        public string TransportType { get; set; }

        public DateTime TransportDate { get; set; }

        public string TransportFee { get; set; }

        public int DriverID { get; set; }

        public int SquadID { get; set; }

        public int VehicleID { get; set; }

        public int TransportRating { get; set; }

        public bool TransportStatus { get; set; }

        [StringLength(300)]
        public string CommentText { get; set; }

        public User User { get; set; }

        public Vehicle Vehicle { get; set; }

        public Squad Squad { get; set; }

        public Company Company { get; set; }

        public Driver Driver { get; set; }
    }
}
