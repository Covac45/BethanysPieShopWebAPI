using BethanysPieShopWebAPI.Auth.Entities;

namespace BethanysPieShopWebAPI.Auth.Services
{
    public interface ITokenService
    {
        string GenerateJWTToken(User user);
        string RenewJWTToken(string token);
    }
}
