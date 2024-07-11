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
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult Add(Rental rental);
    }
}
