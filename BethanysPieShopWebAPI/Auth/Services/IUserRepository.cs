using BethanysPieShopWebAPI.Auth.Models;
using BethanysPieShopWebAPI.Auth.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopWebAPI.Auth.Services
{
    public interface IUserRepository
    {
        Task<User> GetUser(UserDto userDto);

        Task<User> CheckUserCredentials(string username, string password);
    }
}
