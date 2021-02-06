using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    //{
    //    List<Car> _cars;
    //    public InMemoryCarDal()
    //    {
    //        _cars = new List<Car>
    //        {
    //            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2003,Description="ekonomik araba"},
    //            new Car{CarId=2,BrandId=2,ColorId=1,DailyPrice=250,ModelYear=2007,Description="normal araba"},
    //            new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=350,ModelYear=2012,Description="iyi araba"},
    //            new Car{CarId=4,BrandId=3,ColorId=3,DailyPrice=450,ModelYear=2017,Description="güzel araba"},
    //            new Car{CarId=5,BrandId=4,ColorId=2,DailyPrice=550,ModelYear=2020,Description="çok güzel araba"},
    //        };
    //    }
    //    public Car GetById(int id)
    //    {
    //        return _cars.SingleOrDefault(c => c.CarId == id);
    //    }
    //    public void Add(Car car)
    //    {
    //        _cars.Add(car);
    //    }

    //    public void Delete(int carId)
    //    {
    //        Car carToDelete = _cars.SingleOrDefault(c => c.CarId == carId);

    //        _cars.Remove(carToDelete);
    //    }

    //    public List<Car> GetAll()
    //    {
    //        return _cars;
    //    }

    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
    //        carToUpdate.BrandId = carToUpdate.BrandId;
    //        carToUpdate.ColorId = carToUpdate.ColorId;
    //        carToUpdate.DailyPrice = carToUpdate.DailyPrice;
    //        carToUpdate.Description = carToUpdate.Description;
    //        carToUpdate.ModelYear = carToUpdate.ModelYear;

    //        Console.WriteLine(carToUpdate+"Araba Güncellendi");
    //    }

    //    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Car Get(Expression<Func<Car, bool>> filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    void IEntityRepository<Car>.GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Car entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
