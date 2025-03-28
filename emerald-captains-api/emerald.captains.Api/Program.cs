using emerald.captains.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlite("Data Source=../Registrar.sqlite",
b => b.MigrationsAssembly("emerald.captains.Api"))
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();