﻿using System.ComponentModel.DataAnnotations;

namespace HotelApiProject.WebUI.DTOs.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        
        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
