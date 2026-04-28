using JwtBearer.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<AuthService>();
var app = builder.Build();

app.MapGet("/", (AuthService service) 
=> service.GenerateToken(null));

app.Run();
