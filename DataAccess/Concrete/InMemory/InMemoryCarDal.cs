using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1, BrandId=1, DailyPrice=100, Description="C180", ColorId=1, ModelYear="2011"},
                new Car{Id=2, BrandId=2, DailyPrice=750, Description="LaFerrari",ColorId=2, ModelYear="2019"},
                new Car{Id=3, BrandId=3, DailyPrice=50, Description="Doblo",ColorId=3, ModelYear="2015"},
                new Car{Id=4, BrandId=4, DailyPrice=90, Description="Clio",ColorId=4, ModelYear="2020"},
                new Car{Id=5, BrandId=3, DailyPrice=70, Description="Ducato", ColorId=1,ModelYear="2012"},
                new Car{Id=6, BrandId=5, DailyPrice=150, Description="XC 60",ColorId=5, ModelYear="2021"},
                new Car{Id=7, BrandId=6, DailyPrice=250, Description="A8 TDİ",ColorId=6, ModelYear="2019"},
                new Car{Id=8, BrandId=6, DailyPrice=580, Description="R8 Supersport",ColorId=1, ModelYear="2016"},
                new Car{Id=9, BrandId=7, DailyPrice=150, Description="Passat",ColorId=7, ModelYear="2020"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _cars.SingleOrDefault(c => c.Id == car.Id).Id = car.Id;
            _cars.SingleOrDefault(c => c.Id == car.Id).Description = car.Description;
            _cars.SingleOrDefault(c => c.Id == car.Id).DailyPrice = car.DailyPrice;
            _cars.SingleOrDefault(c => c.Id == car.Id).ModelYear = car.ModelYear;
            _cars.SingleOrDefault(c => c.Id == car.Id).BrandId = car.BrandId;
        }
    }
}
