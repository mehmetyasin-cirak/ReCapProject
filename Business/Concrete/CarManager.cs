using Business.Abstract;
using Business.Constants;
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
                return new ErrorResult(Messages.ErrorMessageLenght);
            }
            else
            {
                _iCarDal.Add(car);
                return new SuccessResult(Messages.AddedCar);
            }

        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new Result(true, Messages.DeletedCar);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintanenceTime);
            }
            else
            {
                return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), Messages.ListedCars);
            }

        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.BrandId == brandId), Messages.ListedBrand);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(c => c.Id == carId), Messages.ListedCar);
        }
        public IDataResult<List<Car>> GetByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.DailyPrice >= minPrice && c.DailyPrice <= maxPrice));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails(), Messages.CarDtoListed);
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new Result(true, Messages.UpdatedCar);
        }

    }
}
