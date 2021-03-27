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
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car()
            {
                ColorId = 1,
                BrandId = 1,
                DailyPrice = 200,
                ModelYear = "2021",
                Description = "Mercedes AMG",
            };

            
            //burada arayüzden arabanın özelliklerini girerek yeni bir araba eklemeye çalışıyor

            //Business daki iş kodlarından (if..... vs..) geçerse DataAccess katmanına bağlanacak
            
            carManager.Add(car);


            //mevcut arabalrı listeleyecek
            ListCar(carManager);

        }

        private static void ListCar(CarManager carManager)
        {
            //arabaları listelesin
            Console.WriteLine("Mevcut araba listesi : ");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
