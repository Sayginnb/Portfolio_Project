using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınız Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
    }
}
