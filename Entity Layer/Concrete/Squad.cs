using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Squad
    {
        [Key]

        public int SquadID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(20)]
        public string SquadName { get; set; }

        public string SquadEmail { get; set; }

        [StringLength(20)]
        public string SquadImage { get; set; }

        public bool SquadStatus { get; set; }
    }
}
