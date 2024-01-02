using EntityLayer.Concrete;

namespace MasterGamer.Areas.Admin.Models
{
    public class AddReviewViewModel
    {
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
    }
}
