using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSiteReviewProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}