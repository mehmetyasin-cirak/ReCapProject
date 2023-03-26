using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _iUserDal;

        public UserManager(IUserDal iUserDal)
        {
            _iUserDal = iUserDal;
        }

        public IResult Add(User user)
        {
            _iUserDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _iUserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>();
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>();
        }

        public IResult Update(User user)
        {
            _iUserDal.Update(user);
            return new SuccessResult();
        }
    }
}
