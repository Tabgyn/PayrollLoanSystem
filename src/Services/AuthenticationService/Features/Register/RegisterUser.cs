namespace AuthenticationService.Features.Register;

public class RegisterUser
{
    private readonly IAuthService _authService;

    public record RegisterUserRequest(string Username, string Password);
    public record RegisterUserResponse(bool IsSuccess, string Message);

    public RegisterUser(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<RegisterUserResponse> Handle(RegisterUserRequest request)
    {
        return await _authService.RegisterUserAsync(request);
    }
}
