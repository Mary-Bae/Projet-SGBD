using Interfaces;
using Microsoft.Data.SqlClient;
using Repositories;
using Services;
using System.Data;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddScoped<IAdminSvc, AdminSvc>();
builder.Services.AddScoped<IClientSvc, ClientSvc>();
builder.Services.AddScoped<IAdminRepo, AdminRepo>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("AdminDb");
    return new AdminRepo(new SqlConnection(connectionString));
});

builder.Services.AddScoped<IClientRepo, ClientRepo>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("Server=DESKTOP-D5MF0AD\\SQL2023;Database=Cinemania-PSR12204;User Id=Client;Password=;trustServerCertificate=true;");
    return new ClientRepo(new SqlConnection(connectionString));
});

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
