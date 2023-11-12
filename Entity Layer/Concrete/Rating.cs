using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

namespace Entity_Layer.Concrete
{
    public class Rating
    {
        [Key]

        public int RatingID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(300)]
        public string CommentText { get; set; }
        public int CompanyID { get; set; }
      
        public int BlogRating { get; set; }
       
    }
}

