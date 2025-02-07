namespace AuthenticationService.Features.Login;

public class LoginUser
{
    private readonly IAuthService _authService;

    public record LoginUserRequest(string Username, string Password);
    public record LoginUserResponse(bool IsSuccess, string Token, string Message);

    public LoginUser(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<LoginUserResponse> Handle(LoginUserRequest request)
    {
        return await _authService.LoginUserAsync(request);
    }
}
