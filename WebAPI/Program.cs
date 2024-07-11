using Autofac;
using Autofac.Extensions.DependencyInjection;
using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Concrete;
using ConsoleApp1.Business.DependencyResolvers.Autofac;
using ConsoleApp1.DataAccess.Abstract;
using ConsoleApp1.DataAccess.Concrete;
using RecapProjectCar.Business.Abstract;
using RecapProjectCar.Business.Concrete;
using RecapProjectCar.DataAccess.Abstract;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(
    builder => {
        builder.RegisterModule(new AutofacBusinessModule());
    });
;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<ICarService, CarManager>();
//builder.Services.AddSingleton<ICarDal , EfCarDal>();
builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDal, EfColorDal>();

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
