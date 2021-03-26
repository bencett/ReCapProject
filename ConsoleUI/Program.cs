using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Id=1,BrandId = 4, ColorId = 2, ModelYear = "2011", DailyPrice = 100, Description = "Focus" };
            
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);

            EfBrandDal brandDal = new EfBrandDal();
            EfCarDal carDal = new EfCarDal();
            carDal.GetAll();
        }
    }
}
