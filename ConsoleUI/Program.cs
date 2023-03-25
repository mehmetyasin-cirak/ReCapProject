// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAllByBrandId(1))
{
    Console.WriteLine(car.Description);
}