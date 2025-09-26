using AdventureWorksAPI.Models;
using AdventureWorksAPI.Repositories.ProductRepository;
using AdventureWorksAPI.Repositories.SalesRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AdventureWorks2017Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISalesRepository, SalesRepository>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
//builder.Services.AddCors(options => options.AddPolicy(name: "AllDashboardPro",
//    policy =>
//    {
//        policy.WithOrigins("http://localhost:4200/").AllowAnyMethod().AllowAnyHeader();
//    }));

builder.Services.AddCors(options =>
//{
//        options.AddPolicy("AllowLocalHost",
//            builder => builder.WithOrigins("http://127.0.0.1:5500")
//                              .AllowAnyHeader()
//                              .AllowAnyMethod());
//    });
        {
            options.AddPolicy("AllDashboardPro",
                builder => builder.WithOrigins("http://localhost:4200")
                                  .AllowAnyHeader()
                                  .AllowAnyMethod());
        });

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AdventureWorks2017Context>();
    // Ensure the database is created. In production, consider using migrations instead.
    if (dbContext.Database.IsRelational())
    {
        dbContext.Database.Migrate();
    }
    //else
    //{
    //    dbContext.Database.EnsureCreated();
    //}
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllDashboardPro");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
