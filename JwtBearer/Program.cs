using JwtBearer.Service;
using JwtBearer.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<AuthService>();
var app = builder.Build();

app.MapGet("/", (AuthService service) 
=> service.GenerateToken(new User (1, 
"john.marston@example.com",
 "123",
new [] {"student", "premium "})));

app.Run();
