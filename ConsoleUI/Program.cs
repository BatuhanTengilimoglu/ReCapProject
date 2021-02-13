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
            
            //Resulttesting();
            Rentallist();

        }

        private static void Rentallist()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine($"{rental.Id}\t{rental.CarId}\t{rental.UserName}\t{rental.CompanyName}\t{rental.RentDate}\t{rental.ReturnDate}");
                }
            }
            

           

            
        }

        private static void Resulttesting()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            Console.WriteLine("CarName\t\tBrand Name\t\tColor Name\t\tDaily Price\n");
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName}\t\t{car.BrandName}\t\t\t{car.ColorName}\t\t\t{car.DailyPrice}\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }


    }
}
