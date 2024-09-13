using Microsoft.EntityFrameworkCore;
using Queries.Core;
using Queries.Core.Domain;
using Queries.Core.IRepositories;
using Queries.Persistence;
using Queries.Persistence.Repositories;
using ShopController.Mapping;

var builder = WebApplication.CreateBuilder(args);

#region Database
// Add Database
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MathiasConnection"));
});
#endregion

#region Automapper
// Tilføjer mapping profile
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});
#endregion

builder.Services.AddControllers();
builder.Services.AddScoped<IItemRepo, ItemRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Add controller
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
