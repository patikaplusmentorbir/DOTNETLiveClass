using CustomIdentityWithJwt.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CustomIdentityWithJwt.Jwt
{
    public static class JwtHelper
    {

        public static string GenerateJwt(JwtInfo jwtInfo)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtInfo.SecretKey));

            var credientals = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Id", jwtInfo.Id.ToString()),
                new Claim("Email", jwtInfo.Email),
                new Claim("UserType", jwtInfo.UserType.ToString()), // daha çok manuel kullanımlarda


                // .Net içi Authorization işlemlerinde.
                new Claim(ClaimTypes.Role, jwtInfo.UserType.ToString())

            };

            var expireTime = DateTime.Now.AddMinutes(jwtInfo.ExpireMinutes);

            var tokenDescriptor = new JwtSecurityToken(jwtInfo.Issuer, jwtInfo.Audience,claims,null,expireTime,credientals);

            var token = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

            return token;

            
        }
    }

    
}

