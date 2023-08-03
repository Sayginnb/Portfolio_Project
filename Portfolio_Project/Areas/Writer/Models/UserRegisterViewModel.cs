﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel Url Değerini Giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
    }
}
