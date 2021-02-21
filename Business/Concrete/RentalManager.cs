using Business.Abstarct;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
}
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarRentalInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRented);
        }

        public IResult Delete(Rental rental)
        {
            if (rental.RentDate > DateTime.Now.Date)
            {
                return new ErrorResult(Messages.CarNotDeleted);
            }
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>( _rentalDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult< Rental> GetById(int id)
        {
            
            return new SuccessDataResult<Rental>( _rentalDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetByCustomerRentalDetails(int id)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetByCustomerRentalDetails(id),Messages.CarsListedByCustomer);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>( _rentalDal.GetRentalDetails());
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental); 
        }

        

        IResult IRentalService.Update(Rental rental)
        {
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
