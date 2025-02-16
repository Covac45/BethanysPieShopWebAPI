using BethanysPieShopWebAPI.Auth.Entities;

namespace BethanysPieShopWebAPI.Auth.Services
{
    public interface ITokenGenerationService
    {
        string GenerateJWTToken(User user);

    }
}
