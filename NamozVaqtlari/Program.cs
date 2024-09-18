using NamozVaqtlari.Data;
using NamozVaqtlari.Model.Users;
using NamozVaqtlari.Profilies;
using NamozVaqtlari.Repositoreis;
using NamozVaqtlari.Services.AuthService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddAutoMapper(typeof(UserProfile));

builder.Services.AddScoped<IGenericRepository<User> , GenericRepository<User>>();
builder.Services.AddScoped<IUserAuthService  ,  UserAuthService>();

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
