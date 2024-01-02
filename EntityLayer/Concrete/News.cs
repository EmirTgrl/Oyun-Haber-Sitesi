using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Introduction { get; set; }
        public string ImageUrl { get; set; }
        public string GameName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
