using ConsoleApp1.Entities.Concrete;
using Core.Utilities.Results;
using RecapProjectCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Update(User user);
        IResult Delete(User user);
        IResult Add(User user);
    }
}
