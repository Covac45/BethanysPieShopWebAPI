﻿namespace BethanysPieShopWebAPI.Auth.Models
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string role { get; set; }
    }
}
