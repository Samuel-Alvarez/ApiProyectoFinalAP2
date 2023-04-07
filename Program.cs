using Aplicada2Api.Dal;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var ConStr = builder.Configuration.GetConnectionString("ConStr");

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(ConStr)
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
   
}
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Aplicada2Api v1"));

app.UseHttpsRedirection();

app.UseAuthorization();
/*app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});*/

app.MapControllers();

app.Run();
