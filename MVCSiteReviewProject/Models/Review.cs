using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}