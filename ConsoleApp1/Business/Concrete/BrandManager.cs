using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.DataAccess.Abstract;
using Core.Utilities.Results;
using RecapProjectCar.Entities;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _ıBrandDal;

        public BrandManager(IBrandDal ıBrandDal)
        {
            _ıBrandDal = ıBrandDal;
        }

        public IResult Add(Brand brand)
        {
           _ıBrandDal.Add(brand);
            return new Result(true,Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _ıBrandDal.Delete(brand);
            return new Result(true,Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
           _ıBrandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(_ıBrandDal.GetAll(),Messages.BrandListed); 
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_ıBrandDal.Get(b => b.Id == id));
        }

        public IResult Update(Brand brand)
        {
            brand = _ıBrandDal.Update(brand);
            Console.WriteLine("updated car " + brand.Id);

            return new SuccessDataResult<Brand>(brand);
        }
    }
}
