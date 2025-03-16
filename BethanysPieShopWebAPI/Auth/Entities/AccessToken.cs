namespace BethanysPieShopWebAPI.Auth.Entities
{
    public class AccessToken
    {
        public string Token { get; set; }
        public AccessToken(string token) {
            Token = token;
        }
    }
}
