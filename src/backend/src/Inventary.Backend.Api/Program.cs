using Inventary.backend.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(Route => Route.LowercaseUrls = true);
builder.Services.AddDbContext<InventaryDBContext>(opciones => 
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    InventaryDBContext context = scope.ServiceProvider.GetRequiredService<InventaryDBContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
