using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            // İş kodları yazılacak.
            return _iCarDal.GetAll();

        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _iCarDal.GetAll(b => b.BrandId == brandId);
        }

        public List<Car> GetByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            return _iCarDal.GetAll(p => p.DailyPrice >= minPrice && p.DailyPrice <= maxPrice);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }
    }
}
