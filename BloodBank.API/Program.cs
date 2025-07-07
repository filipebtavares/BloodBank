using BloodBank.API.Middlewares.Exception;
using BloodBank.Application;
using BloodBank.Application.Service;
using BloodBank.Application.Validation;
using BloodBank.infrastructure;
using BloodBank.infrastructure.ExternalService.ViaCep;
using FluentValidation;
using FluentValidation.AspNetCore;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddExceptionHandler<ApiExceptionHandlers>();
builder.Services.AddProblemDetails();

builder.Services.AddScoped<ICepService, CepService>();
builder.Services.AddAplication().AddInfrastructure(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

builder.Services.AddValidatorsFromAssemblyContaining<CreateDonorCommandValidation>();
builder.Services.AddFluentValidationAutoValidation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
