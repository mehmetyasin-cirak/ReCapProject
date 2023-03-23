using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    //{
    //    List<Car> _cars;
    //    public InMemoryCarDal()
    //    {
    //        _cars = new List<Car> {
    //            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = 2012, Description = "Audi Q5" },
    //            new Car {Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 5000, ModelYear = 2022, Description = "Audi Q8"},
    //            new Car {Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 1200, ModelYear = 2022, Description = "Audi A4" } };
    //    }
    //    public void Add(Car car)
    //    {
    //        _cars.Add(car);
    //    }

    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = null;
    //        foreach (var item in _cars)
    //        {
    //            if (car.Id == item.Id)
    //            {
    //                carToDelete = item;
    //            }
    //        }
    //        _cars.Remove(carToDelete);

    //    }

    //    public List<Car> GetAll()
    //    {
    //        return _cars;
    //    }

    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = null;
    //        foreach (var item in _cars)
    //        {
    //            if (car.Id == item.Id)
    //            {
    //                carToUpdate = item;
    //            }
    //        }
    //        _cars.Remove(carToUpdate);
    //    }
    
}
