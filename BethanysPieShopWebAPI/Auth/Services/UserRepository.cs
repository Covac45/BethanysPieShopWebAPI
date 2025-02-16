using BethanysPieShopWebAPI.Auth.Models;
using BethanysPieShopWebAPI.Auth.Database;
using BethanysPieShopWebAPI.Auth.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BethanysPieShopWebAPI.Products.Database;

namespace BethanysPieShopWebAPI.Auth.Services
{
    public class UserRepository : IUserRepository
    {
        private UserContext _dbContext;

        public UserRepository(UserContext userContext)
        {
            _dbContext = userContext ?? throw new ArgumentNullException(nameof(userContext)); ;
        }

        public async Task<User> GetUser(UserDto userDto)
        {
            var userToReturn = await CheckUserCredentials(userDto.Username, userDto.Password);

            return userToReturn;
        }

        public async Task<User> CheckUserCredentials(string username, string password)
        {
            //check user exists

            var userToCheck = await _dbContext.Users
                .Select(u => u).Where(u => u.Username == username)
                .FirstOrDefaultAsync(u => u.Password == password);                

            return userToCheck;
        }

    }
}
