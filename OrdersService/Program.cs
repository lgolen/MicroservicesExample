using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();  // Add this line

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();  // Optional, if you want HTTPS (remove if you're not using it)
app.MapControllers();        // Map controllers to the HTTP request pipeline

app.Run();
