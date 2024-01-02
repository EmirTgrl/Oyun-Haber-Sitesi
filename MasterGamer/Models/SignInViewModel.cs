using System.ComponentModel.DataAnnotations;

namespace MasterGamer.Models
{
    public class SignInViewModel
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
