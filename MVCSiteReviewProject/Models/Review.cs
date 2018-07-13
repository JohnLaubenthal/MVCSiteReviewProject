using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCSiteReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string ReviewTitle { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}