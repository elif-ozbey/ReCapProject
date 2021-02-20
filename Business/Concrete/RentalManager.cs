using Business.Abstarct;
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
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public Rental GetById(int id)
        {
            return _rentalDal.Get(p => p.CarId == id);
        }

        public List<RentalDetailDto> GetByCustomerRentalDetails(int id)
        {
            return _rentalDal.GetByCustomerRentalDetails(id);
        }

        public List<RentalDetailDto> GetRentalDetails()
        {
            return _rentalDal.GetRentalDetails();
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental); 
        }

       
    }
}
