using Business.Concrete;
using Business.Constants;
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

            //CarManagerTesting();
            RentalManagerTest();

        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();
            var result2 = rentalManager.GetAllRentals();

            Console.WriteLine("**********Kiralanmış araba eklemeyi dene*********\n");
            Console.WriteLine(rentalManager.Add(new Rental() { CarId = 1, CustomerId = 3, RentDate = DateTime.Now }).Message);


            Console.WriteLine("\n*********Araba eklemeyi dene*********\n");
            Console.WriteLine(rentalManager.Add(new Rental() { CarId = 3, CustomerId = 4, RentDate = DateTime.Now, ReturnDate = DateTime.Now }).Message);

            Console.WriteLine("\n**********Kiralık arabaları listele**********\n");
            if (result2.Success)
            {
                Console.WriteLine("ID\tCAR ID\tCUSTOMER ID\t\tRENT DATE\tRETURN DATE");
                foreach (var rental in result2.Data)
                {
                    Console.WriteLine($"{rental.Id}\t{rental.CarId}\t{rental.CustomerId}\t\t{rental.RentDate}\t{rental.ReturnDate}");
                }
            }
            else
            {
                Console.WriteLine(Messages.NoRentals);
            }


            if (result.Success)
            {
                Console.WriteLine("\n**********Kiralık arabaları detaylarıyla listele**********\n");
                Console.WriteLine("ID\tCAR ID\tCUSTOMER ID\t\tRENT DATE\tRETURN DATE");
                foreach (var rental in result.Data)
                {
                    Console.WriteLine($"{rental.Id}\t{rental.CarId}\t{rental.UserName}\t{rental.CompanyName}\t{rental.RentDate}\t{rental.ReturnDate}");
                }
            }





        }

        private static void CarManagerTesting()
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
