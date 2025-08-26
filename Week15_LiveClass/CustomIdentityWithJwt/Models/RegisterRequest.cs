using System.ComponentModel.DataAnnotations;

namespace CustomIdentityWithJwt.Models
{
    public class RegisterRequest
    {

        [EmailAddress]
        [Required(ErrorMessage = "Email girmek zorunludur.")] // artık işlevi yok ama yazılıyor. Bir de ErrorMessage vermek için gerekli.
        [Length(15,50)]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        

    }
}
