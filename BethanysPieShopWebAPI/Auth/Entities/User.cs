﻿namespace BethanysPieShopWebAPI.Auth.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public User (
            string username,
            string password,
            string firstName,
            string lastName,
            string role
            )
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
    }
}
