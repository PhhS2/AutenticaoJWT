using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtBearer.Models;
using Microsoft.IdentityModel.Tokens;

namespace JwtBearer.Service;


public class AuthService
{
    public string GenerateToken(User user)
    {
        var handler = new JwtSecurityTokenHandler(); 

        var key = Encoding.ASCII.GetBytes(Configuration.PrivateKey);
        var credentials = new SigningCredentials(
            new SymmetricSecurityKey(key),
            algorithm:SecurityAlgorithms.HmacSha256Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = GenerateClaims(user),
            SigningCredentials = credentials,
            Expires = DateTime.UtcNow.AddHours(1),
        };
       
        var token = handler.CreateToken(tokenDescriptor);

        return handler.WriteToken(token);
    }

    private static ClaimsIdentity GenerateClaims(User user)
    {
        var ci = new ClaimsIdentity();
        ci.AddClaim(
            new Claim(ClaimTypes.Name, user.Id.ToString()));
            foreach (var role in user.roles)
            {
            ci.AddClaim( new Claim(ClaimTypes.Role, role));
            }
            return ci; 
    }
}