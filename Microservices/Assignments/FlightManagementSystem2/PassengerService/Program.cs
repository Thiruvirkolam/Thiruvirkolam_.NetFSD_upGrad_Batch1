using Microsoft.EntityFrameworkCore;
using PassengerService.Data;
using PassengerService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PassengerDB;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddScoped<IPassengerService, PassengerService.Services.PassengerService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run("http://localhost:5003");