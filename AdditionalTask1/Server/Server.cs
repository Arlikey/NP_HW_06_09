using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("api/user/registration", (User user) =>
{
    if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
    {
        return Results.BadRequest(new { message = "Invalid user data." });
    }
    else
    {
        return Results.Json(user);
    }
});

app.Run();

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}