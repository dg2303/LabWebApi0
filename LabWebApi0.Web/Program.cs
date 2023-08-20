using Microsoft.AspNetCore.SpaServices.AngularCli;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

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

app.UseCors(c =>
{
    c.AllowAnyOrigin();
    c.AllowAnyHeader();
    c.AllowAnyMethod();
});

app.UseAuthorization();



app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";
    spa.UseAngularCliServer(npmScript: "start");
});


app.Run();
