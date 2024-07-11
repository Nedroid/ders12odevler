using ConsoleApp1.DataAccess.Abstract;
using ConsoleApp1.Entities.Concrete;
using RecapProjectCar.DataAccess.Concrete;
using RecapProjectCar.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concrete
{
    public class EfUserDal:EfEntityRepositoryBase<User,RecapCarContext>,IUserDal
    {
    }
}
