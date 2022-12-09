using ekzApi.Models;

var builder = WebApplication.CreateBuilder(args);
var myAllowSpecifficOrigins = "_myAllowSpecifficOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecifficOrigins, builder =>
    {
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(myAllowSpecifficOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
