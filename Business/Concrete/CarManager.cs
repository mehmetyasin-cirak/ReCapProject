using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult("Ürün açıklaması en az 2 karakter olmalıdır.");
            }
            else
            {
                _iCarDal.Add(car);
                return new SuccessResult("Ürün eklendi.");
            }

        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new Result(true, "Ürün silindi.");
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>("Bakım saati");
            }
            else
            {
                return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), "Listelendi.");
            }


        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(b => b.BrandId == brandId), "Markaya göre getirildi.");
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(c => c.Id == carId), "Markaya göre getirildi.");
        }
        public IDataResult<List<Car>> GetByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(p => p.DailyPrice >= minPrice && p.DailyPrice <= maxPrice));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails(), "");
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new Result(true, "Ürün güncellendi.");
        }

    }
}
