using BE_Project_Exe201;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Helpers;
using Repository.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddIdentity<Person, IdentityRole>()
    .AddEntityFrameworkStores<HabestContext>()
    .AddDefaultTokenProviders();

//add DJ
builder.Services.AddApiWebService();

//config cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("app-cors",
        builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .WithExposedHeaders("X-Pagination")
            .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<HabestContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Habest"));
});

builder.Services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("app-cors");
app.UseAuthorization();

app.MapControllers();

app.Run();
