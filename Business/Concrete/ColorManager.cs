﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal brandDal)
        {
            _colorDal = brandDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2 )
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>> (_colorDal.GetAll());

        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color> (_colorDal.Get(c => c.ColorId == id));
        }

        public IResult Update(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

    }
}
