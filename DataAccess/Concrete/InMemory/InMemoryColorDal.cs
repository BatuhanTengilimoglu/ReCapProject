using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryColorDal : IColorDal
    //{
    //    List<Color> _colors;
    //    public InMemoryColorDal()
    //    {
    //        _colors = new List<Color>
    //        {
    //            new Color{ColorId=1,ColorName="Siyah"},
    //            new Color{ColorId=2,ColorName="Gri"},
    //            new Color{ColorId=3,ColorName="Beyaz"},
                
    //        };
    //    }
    //    public void Add(Color color)
    //    {
    //        _colors.Add(color);
    //    }

    //    public void Delete(int colorId)
    //    {
    //        Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == colorId);
    //        _colors.Remove(colorToDelete);
    //    }

    //    public List<Color> GetAll()
    //    {
    //        return _colors;
    //    }

    //    public void Update(Color color)
    //    {
    //        Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
    //        colorToUpdate.ColorName = colorToUpdate.ColorName;
    //    }
    //}
}
