using BethanysPieShopWebAPI.Auth.Services;
using BethanysPieShopWebAPI.Auth.Entities;
using BethanysPieShopWebAPI.Auth.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BethanysPieShopWebAPI.Auth.Controller
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        public IUserRepository _userRepository;
        public ITokenGenerationService _tokenGneerationService;

        public IConfiguration _configuration { get; }


        public AuthenticationController(IConfiguration configuration, IUserRepository userRepository, ITokenGenerationService tokenGneerationService)
        {
            _userRepository = userRepository;
            _tokenGneerationService = tokenGneerationService;
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public class AuthenticationRequestBody
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        
        [HttpPost("authenticate")]
        public async Task<ActionResult<string>> Authenticate(AuthenticationRequestBody authenticationRequestBody)
        {
            //Validate user credentials
            var user = await _userRepository.CheckUserCredentials(
                authenticationRequestBody.Username,
                authenticationRequestBody.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            //convert to string and return to user
            var tokenToReturn = _tokenGneerationService.GenerateJWTToken(user);
            return Ok(tokenToReturn);
        }
    }
}
