using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
       
    }
}
