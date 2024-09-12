using MediatR;
using FluentValidation;
using CqrsMediatRFluentValidation;
using Products.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Products.Application.Behaviors;
using MassTransit;
using Products.Application.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQLConnection")));

builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);   
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


builder.Services.AddScoped<Product>();

builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();