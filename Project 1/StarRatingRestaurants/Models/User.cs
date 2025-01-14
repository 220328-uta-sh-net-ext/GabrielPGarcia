﻿namespace Models
{
    public class User : IUserModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReviewerId { get; set; }
        ~User() { }
        public User()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            UserName = "";
            Password = "";
            ReviewerId = "";
        }

    }
}
