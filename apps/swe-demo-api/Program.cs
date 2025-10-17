using SweDemoBackend.Application.UseCases;
using SweDemoBackend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => {   options.AddDefaultPolicy(policy =>
  {
    policy.WithOrigins("http://localhost:4200")
          .AllowAnyHeader()
          .AllowAnyMethod();
  });
});

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);

// Add use cases
builder.Services.AddScoped<LegoSetUseCase>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
