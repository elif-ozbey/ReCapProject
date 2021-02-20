using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IRentalService 
    {
       List<Rental> GetAll();
        Rental GetById(int id);
        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
        List<RentalDetailDto> GetRentalDetails();
        List<RentalDetailDto> GetByCustomerRentalDetails(int id);
    }
}
