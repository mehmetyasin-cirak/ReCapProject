// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    carManager.Add(new Car
    {
        BrandId = 1,
        ColorId = 2,
        ModelYear = 2020,
        DailyPrice = 2000,
        Description = "Mercedes A180"
    });

    //foreach (var car in carmanager.getcardetails())
    //{
    //    console.writeline(car.carname + "/  " + car.brandname + "/  " + car.colorname + "/  " + car.unitsprice);
    //}

    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.Description);
    }
}