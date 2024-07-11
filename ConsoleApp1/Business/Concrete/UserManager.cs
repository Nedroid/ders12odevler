using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.DataAccess.Abstract;
using ConsoleApp1.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _IuserDal;

        public UserManager(IUserDal ıuserDal)
        {
            _IuserDal = ıuserDal;
        }

        public IResult Add(User user)
        {
            _IuserDal.Add(user);
            return new Result(true, Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _IuserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            _IuserDal.GetAll();
            return new SuccessDataResult<List<User>>(_IuserDal.GetAll(),Messages.UserListed);
        }

        public IResult Update(User user)
        {
            _IuserDal.Update(user);
            return new SuccessResult();
        }
    }
}
