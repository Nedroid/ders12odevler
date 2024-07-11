﻿
using RecapProjectCar.Business.Concrete;
using RecapProjectCar.Business.Abstract;
using RecapProjectCar.DataAccess.Concrete;
using RecapProjectCar.Entities.Concrete;
using ConsoleApp1.DataAccess.Concrete;
using ConsoleApp1.Business.Concrete;
using ConsoleApp1.Business.Abstract;

CarManager carManager = new CarManager(new EfCarDal());
Car car1 = new Car() { Id = 7, BrandId = 3, ColorId = 2, DailyPrice = 200, Description = "Porshe911", ModelYear = 2022 };
//((ICarService)carManager).Add(car1);

foreach (var car in ((ICarService)carManager).GetCarDetails().Data)
{
    Console.WriteLine("ID=" + car.Id
        + "Color Name=" + car.ColorName +
        "Brand Name=" + car.BrandName +
        "Model Year=" + car.ModelYear +
        "Car Description=" + car.Description +
        "Car Daily Price=" + car.DailyPrice +
        "\n------------------------------\n");
}
Console.WriteLine("Get By ıd ");

Console.WriteLine("ID=" + ((ICarService)carManager).GetById(4).Data.Id
        + "Color ID=" + ((ICarService)carManager).GetById(4).Data.ColorId +
        "Brand Id=" + ((ICarService)carManager).GetById(4).Data.BrandId +
        "Model Year=" + ((ICarService)carManager).GetById(4).Data.ModelYear +
        "Car Description=" + ((ICarService)carManager).GetById(4).Data.Description +
        "\n------------------------------\n");

Console.WriteLine("USer Listed");
UserManager userManager = new UserManager(new EfUserDal());
foreach (var user in( (IUserService)userManager).GetAll().Data)
{
    Console.WriteLine("user name" + user.FirstName);
}
Console.ReadLine();