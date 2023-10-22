using Microsoft.EntityFrameworkCore;
using SistemaDdeTarefas.Data;
using SistemaDdeTarefas.Repositorios;
using SistemaDdeTarefas.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaTarefasDBContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
    );

// Ingeção de Dependencia 
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

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
