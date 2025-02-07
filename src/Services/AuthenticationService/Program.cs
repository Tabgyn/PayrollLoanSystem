using AuthenticationService;
using static AuthenticationService.Features.Login.LoginUser;
using static AuthenticationService.Features.Register.RegisterUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/register", async (RegisterUserRequest request, IAuthService authService) =>
{
    var result = await authService.RegisterUserAsync(request);
    return result.IsSuccess ? Results.Ok(result) : Results.BadRequest(result);
});

app.MapPost("/login", async (LoginUserRequest request, IAuthService authService) =>
{
    var result = await authService.LoginUserAsync(request);
    return result.IsSuccess ? Results.Ok(result) : Results.BadRequest(result);
});

app.UseHttpsRedirection();
app.Run();
