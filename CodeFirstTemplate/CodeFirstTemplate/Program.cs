using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IDbService, DbService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();


//dotnet ef migrations add (nazwa tego co robimy)
//dotnet ef database update

//dotnet ef migrations add (nazwa tego co robimy)
//dotnet ef database update
//dotnet tool install --global dotnet-ef --version 8.*

//dotnet new tool-manifest
//dotnet tool install dotnet-ef
