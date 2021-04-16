﻿using System.ComponentModel.DataAnnotations;

namespace CyberShop.Web.Models.AccountModels
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }


    }
}