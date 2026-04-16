using BookingService.Data;
using BookingService.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookingDB;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddScoped<IBookingService, BookingService.Services.BookingService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run("http://localhost:5002");