﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryBrandDal : IBrandDal
    //{
    //    List<Brand> _brands;
    //    public InMemoryBrandDal()
    //    {
    //        _brands = new List<Brand> {
    //        new Brand { BrandId = 1, BrandName = "Audi" },
    //        new Brand { BrandId = 2, BrandName = "BMW" },
    //        new Brand { BrandId = 3, BrandName = "Mercedes" },
    //        new Brand { BrandId = 4, BrandName = "Ford" }
    //        };
    //    }
    //    public void Add(Brand brand)
    //    {
    //        _brands.Add(brand);
    //    }

    //    public void Delete(int brandId)
    //    {
    //        Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brandId);

    //        _brands.Remove(brandToDelete);
    //    }

    //    public void Delete(Brand entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Brand Get(Expression<Func<Brand, bool>> filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Brand> GetAll()
    //    {
    //        return _brands;
    //    }

    //    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Brand brand)
    //    {
    //        Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
    //        brandToUpdate.BrandName = brand.BrandName;
    //    }
    //}
}
