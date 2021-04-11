using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal brandDal)
        {
            _colorDal = brandDal;
        }

        [SecuredOperation("color.add,moderator,admin")]
        public IResult Add(Color color)
        {
           
            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        [SecuredOperation("color.delete,moderator,admin")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            
            return new SuccessDataResult<List<Color>> (_colorDal.GetAll());

        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color> (_colorDal.Get(c => c.ColorId == id));
        }

        [SecuredOperation("color.update,moderator,admin")]
        public IResult Update(Color color)
        {
           
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

    }
}
