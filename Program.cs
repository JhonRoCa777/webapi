using API_TODO;
using Microsoft.EntityFrameworkCore;
using webapi.Application.Repositories;
using webapi.Application.Services;
using webapi.Domain.Repositories;
using webapi.Infrastructure.Models;
using webapi.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<WebApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();

//Scoped
builder.Services.AddScoped<IUnitOfWorkRepository, UnitOfWorkEFRepository>();
builder.Services.AddScoped<ITareaRepository, TareaEFRepository>();
builder.Services.AddScoped<ITareaService, TareaService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// CORS
builder.Services.AddCors(o =>
{
    o.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Aplicar migraciones
//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<WebApiContext>();
//    dbContext.Database.Migrate();
//}

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
