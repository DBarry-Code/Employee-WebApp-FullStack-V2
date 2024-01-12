using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to connect the Database.
builder.Services.AddDbContext<DataContext>(
    Options => Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConection"))
);

//Add Contoller
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Mapping Controller
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(Options =>
{
    Options.AllowAnyOrigin();
    Options.AllowAnyHeader();
    Options.AllowAnyMethod();
});

app.UseHttpsRedirection();

app.Run();
