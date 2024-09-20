using Microsoft.EntityFrameworkCore;
using NamozVaqtlari.Data;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Profilies;
using NamozVaqtlari.Repositoreis;
using NamozVaqtlari.Services.AuthService;
using NamozVaqtlari.Services.SmsService;


var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddAutoMapper(typeof(UserProfile));

builder.Services.AddScoped<IGenericRepository<User> , GenericRepository<User>>();
builder.Services.AddScoped<IUserAuthService  ,  UserAuthService>();
builder.Services.AddScoped<ISmsService, SmsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
