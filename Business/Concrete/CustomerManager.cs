using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _iCustomerDal;

        public CustomerManager(ICustomerDal iCustomerDal)
        {
            _iCustomerDal = iCustomerDal;
        }

        public IResult Add(Customer customer)
        {
            _iCustomerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _iCustomerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>();
        }

        public IDataResult<Customer> GetById(int useId)
        {
            return new SuccessDataResult<Customer>();  
        }

        public IResult Update(Customer customer)
        {
            _iCustomerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
