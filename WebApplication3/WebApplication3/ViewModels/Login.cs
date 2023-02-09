﻿using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace WebApplication3.ViewModels
{
    public class Login
    {

        [Required]
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)] 
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
