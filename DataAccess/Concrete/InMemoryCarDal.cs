using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id=1, BrandId="Mercedes", DailyPrice=100, Description="C180", ColorId="Beyaz", ModelYear="2011"},
                new Car{Id=2, BrandId="Ferrari", DailyPrice=750, Description="LaFerrari",ColorId="Lacivert", ModelYear="2019"},
                new Car{Id=3, BrandId="Fiat", DailyPrice=50, Description="Doblo",ColorId="Sarı", ModelYear="2015"},
                new Car{Id=4, BrandId="Renault", DailyPrice=90, Description="Clio",ColorId="Gri", ModelYear="2020"},
                new Car{Id=5, BrandId="Fiat", DailyPrice=70, Description="Ducato", ColorId="Beyaz",ModelYear="2012"},
                new Car{Id=6, BrandId="Volvo", DailyPrice=150, Description="XC 60",ColorId="Siyah", ModelYear="2021"},
                new Car{Id=7, BrandId="Audi", DailyPrice=250, Description="A8 TDİ",ColorId="Kırmızı", ModelYear="2019"},
                new Car{Id=8, BrandId="Audi", DailyPrice=580, Description="R8 Supersport",ColorId="Beyaz", ModelYear="2016"},
                new Car{Id=9, BrandId="Volkswagen", DailyPrice=150, Description="Passat",ColorId="Krom", ModelYear="2020"}
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
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
