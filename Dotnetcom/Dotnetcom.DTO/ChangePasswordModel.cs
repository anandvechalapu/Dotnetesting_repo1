﻿namespace Dotnetcom
{
    public class ChangePasswordModel
    {
        public int Id {get; set;}
        public string OldPassword {get; set;}
        public string NewPassword {get; set;}
        public string ConfirmPassword {get; set;}
    }
}