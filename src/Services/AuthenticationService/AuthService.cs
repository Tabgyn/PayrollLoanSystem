using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using AuthenticationService.Infrastructure;
using AuthenticationService.Models;
using static AuthenticationService.Features.Login.LoginUser;
using static AuthenticationService.Features.Register.RegisterUser;

namespace AuthenticationService;

public class AuthService : IAuthService
{
    private static readonly ConcurrentDictionary<string, User> _users = new();
    private readonly JwtTokenGenerator _jwtGenerator;

    public AuthService(JwtTokenGenerator jwtGenerator)
    {
        _jwtGenerator = jwtGenerator;
    }

    public async Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        if (_users.ContainsKey(request.Username))
        {
            return new RegisterUserResponse(false, "User already exists.");
        }

        var passwordHash = HashPassword(request.Password);
        var user = new User { Username = request.Username, PasswordHash = passwordHash };

        _users[request.Username] = user;
        return new RegisterUserResponse(true, "User registered successfully.");
    }

    public async Task<LoginUserResponse> LoginUserAsync(LoginUserRequest request)
    {
        if (!_users.TryGetValue(request.Username, out var user) || !VerifyPassword(request.Password, user.PasswordHash))
        {
            return new LoginUserResponse(false, string.Empty, "Invalid credentials.");
        }

        var token = _jwtGenerator.GenerateToken(user);
        return new LoginUserResponse(true, token, "Login successful.");
    }

    private static string HashPassword(string password)
    {
        return Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
    }

    private static bool VerifyPassword(string password, string hashedPassword)
    {
        return HashPassword(password) == hashedPassword;
    }
}
