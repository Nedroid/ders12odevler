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
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Add(Customer customer);
    }
}
