using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//* Anything above app = builder.buid() is for adding services and anything below is for Http request *//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
