using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class AuthController
{
    public string GerarToken (Usuario usuario)
    {
        var handler = new JwtSecurityTokenHandler();

        var chaveBytes = Encoding.ASCII.GetBytes(Configuration.PrivateKey);
        var credenciais = new SigningCredentials(
            new SymmetricSecurityKey(chaveBytes),
            SecurityAlgorithms.HmacSha256Signature
        );

        var descritorToken = new SecurityTokenDescriptor
        {
            SigningCredentials = credenciais,
            Expires = DateTime.UtcNow.AddHours(1)
        };
        
        var token = handler.CreateToken(descritorToken);

        return handler.WriteToken(token);
    }
}