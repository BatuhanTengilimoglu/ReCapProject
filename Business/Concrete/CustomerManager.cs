using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager :ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        
        public IResult Add(Customer customer)
        {
            if (customer.UserId == (_customerDal as Customer).UserId || customer.Id == (_customerDal as Customer).Id)
            {
                return new ErrorResult(Messages.CustomerIsAlreadyExisting);
            }
            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        [SecuredOperation("customer.delete,moderator,admin")]
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(Messages.CustomerDeleted);
        }

        [SecuredOperation("customer.get,moderator,admin")]
        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        [SecuredOperation("customer.get,moderator,admin")]
        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id));
        }

        public IDataResult<Customer> GetByCompanyName(string companyName)
        {
           
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CompanyName.Contains(companyName)), Messages.CustomersListedByCompanyName);
        }

        [SecuredOperation("customer.update,moderator,admin")]
        public IResult Update(Customer customer)
        {
            
            _customerDal.Update(customer);

            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
