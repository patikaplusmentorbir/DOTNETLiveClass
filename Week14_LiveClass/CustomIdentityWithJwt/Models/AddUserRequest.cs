﻿namespace CustomIdentityWithJwt.Models
{
    public class AddUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

    }
}
