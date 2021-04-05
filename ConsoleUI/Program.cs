using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 6,
                ColorId = 7,
                ModelYear = "2021",
                DailyPrice= 80,
                Description="Proace City"

            });

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Çetin",
                LastName = "Ürün",
                Email = "cetinurun.12@outlook.com",
                Password = "Bubenimsifrem_4242!"

            });

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine
                        (
                            car.BrandName + " " +
                            car.CarName + " " +
                            car.ColorName + " | " + "Daily Price: " +
                            car.DailyPrice
                        );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
