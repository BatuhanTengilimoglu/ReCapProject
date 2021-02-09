using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.CarDbContext;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RentACarContext>,ICarDal
    {
       public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = ca.CarId,
                                 BrandId = br.BrandId,
                                 ColorId = co.ColorId,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return result.ToList();
                             
            }
        }
    }
}
