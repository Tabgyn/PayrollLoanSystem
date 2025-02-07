using static AuthenticationService.Features.Login.LoginUser;
using static AuthenticationService.Features.Register.RegisterUser;

namespace AuthenticationService;

public interface IAuthService
{
    Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request);
    Task<LoginUserResponse> LoginUserAsync(LoginUserRequest request);
}
