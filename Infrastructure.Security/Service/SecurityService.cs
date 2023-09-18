using Domain.Entities;
using Infrastructure.Security.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Security.Service
{
    public class SecurityService : ISecurityService
    {
        private IConfiguration _configuration;
        string secret = string.Empty;

        public SecurityService(IConfiguration configuration)
        {
            _configuration = configuration;

            secret = _configuration.GetSection("Security").GetSection("Secret").Value;
        }

        public string GenereateToken(AuthEntity authEntity)
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, authEntity.Id.ToString()),
                new Claim(ClaimTypes.Name, authEntity.Login.ToString()),
                new Claim(ClaimTypes.Name, authEntity.Nome.ToString()),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString())
            };

            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            JwtHeader jwtHeader = new JwtHeader(signingCredentials);
            JwtPayload jwtPayload = new JwtPayload(claims);
            JwtSecurityToken token = new JwtSecurityToken(jwtHeader, jwtPayload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
