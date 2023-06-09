﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0915Filters.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is blank")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is blank")]
        public string Password { get; set; }
    }
}