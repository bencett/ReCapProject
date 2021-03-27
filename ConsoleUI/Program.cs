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

            //araba ekleyelim
            //burada arayüzden arabanın özelliklerini girerek yeni bir araba eklemeye çalışıyoruz
            //arayüzden Business a bağlanıyoruz
            //Business daki iş kodlarından (if..... vs..) geçerse DataAccess katmanına bağlanacağız
            //DataAccess de araba kaydedilecek
            carManager.Add(car);


            //mevcut arabalrı listeleyelim
            ArabaListele(carManager);

        }

        private static void ArabaListele(CarManager carManager)
        {
            //arabaları listeleyelim
            Console.WriteLine("mevcut araba listesi : ");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
