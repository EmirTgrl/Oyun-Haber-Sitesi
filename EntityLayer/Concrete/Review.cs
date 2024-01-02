using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public string ImageUrl { get; set; }
        public string Introduction { get; set; }
        public string GameName { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public DateTime Date { get; set; }
        public double Rating { get; set; }
        public int? TestimonialId { get; set; }
        public Testimonial? Testimonial { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
