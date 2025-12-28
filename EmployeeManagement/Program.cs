using EmployeeManagement.BusinessLayer;
using EmployeeManagement.BusinessLayer.Interfaces;
using EmployeeManagement.BusinessLayer.Services;
using EmployeeManagement.DataLayer.Context;
using EmployeeManagement.DataLayer.Repositorise;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SwaggerTest",
        Version = "v1",
    });
});

//Connection String
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));

//For Auto Mapper Functionality
builder.Services.AddAutoMapper(typeof(EmployeeManagement.BusinessLayer.MapperClass).Assembly);

//Service Registeration
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SwaggerTest v1");
    c.RoutePrefix =string.Empty;

});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
