using A1ReConsole.API.Middleware;
using A1ReConsole.Core;
using A1ReConsole.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

// Add controllers to the service collection
builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();

// Routing
app.UseRouting();

// Auth
app.UseAuthentication();
app.UseAuthorization();

// Controller routes
app.MapControllers();

app.Run();
