using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext rentACarContext = new RentACarContext())
            {
                var result = from car in rentACarContext.Cars
                             join brand in rentACarContext.Brands
                             on car.BrandId equals brand.BrandId
                             //from car in rentACarContext.Cars
                             join color in rentACarContext.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 CarName = car.Description,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 UnitsPrice = car.DailyPrice
                             };
                return result.ToList();
            }


        }
    }
}
