using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());


          
            GetCarDetails(carManager, brandManager, colorManager);
            
        }

        private static void GetCarDetails(CarManager carManager,BrandManager brandManager,ColorManager colorManager)
        {
            var result = from c in carManager.GetAll()
                         join b in brandManager.GetAll()
                         on c.BrandId equals b.BrandId
                         join co in colorManager.GetAll()
                         on c.ColorId equals co.ColorId
                         orderby c.CarId ascending
                         select ("ID: "+c.CarId,"\nMarka: "+ b.BrandName, "\nRenk: "+co.ColorName, "\nGünlük ücret: "+c.DailyPrice, "\nAçıklama: "+c.Description+"\n");

            foreach (var cars in result)
            {
                Console.WriteLine(cars);
            }
        }
        


    }
}
