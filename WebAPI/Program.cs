using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using WebAPI.Classes.AutoReg;
using WebAPI.Interface;
using WebAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ZdorzhyievSwebContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("dataConnect"),
                    new MySqlServerVersion(new Version(8, 0, 26))));
builder.Services.AddTransient<IUserProfile, AutorizationClass>();
builder.Services.AddTransient<IUserProfilePOST, RegistrationClass>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
