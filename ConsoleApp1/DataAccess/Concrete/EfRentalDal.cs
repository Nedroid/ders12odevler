using ConsoleApp1.DataAccess.Abstract;
using ConsoleApp1.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using RecapProjectCar.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concrete
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,RecapCarContext>,IRentalDal
    {
    }
}
