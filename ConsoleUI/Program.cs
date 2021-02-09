using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing();
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("CarName\t\tBrand Name\t\tColor Name\t\tDaily Price\n");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarName}\t\t{car.BrandName}\t\t\t{car.ColorName}\t\t\t{car.DailyPrice}\n");
            }
            
        }


        private static void Testing()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("--------Brand Id'si 1 olan arabalar-------- \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("\n\n--------Color Id'si 2 olan arabalar-------- \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("\n\n--------Id'si 2 olan araba-------- \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
            Car carById = carManager.GetById(2);
            Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Description}");


            Console.WriteLine("\n\n--------Günlük fiyat aralığı 100 ile 250 olan arabalar-------- \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetByDailyPrice(100, 250))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("\n");

            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -150, ModelYear = "2008", Description = "Güzel araba" });
            brandManager.Add(new Brand { BrandName = "z" });
        }
    }
}
