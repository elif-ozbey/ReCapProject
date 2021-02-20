using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetByCustomerRentalDetails(int customerid )
        {
            using (RentACarContext context = new RentACarContext()) 
            {
                var result = from a in context.Rentals
                             join c in context.Cars on a.CarId equals c.Id
                             join d in context.Customers on a.CustomerId equals d.Id
                             select new RentalDetailDto
                             {
                                 RentalId = a.RentalId,
                                 CarId = c.Id,
                                 CustomerId = d.Id,
                                 RentDate = a.RentDate,
                                 ReturnDate = a.ReturnDate
                             };
                return result.Where(d=> d.CustomerId==customerid).ToList();

            }
        }

       

        public List<RentalDetailDto>GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext()) 
            {
                var result = from a in context.Rentals
                             join c in context.Cars on a.CarId equals c.Id
                             join d in context.Customers on a.CustomerId equals d.Id
                             select new RentalDetailDto
                             {
                                 RentalId = a.RentalId,
                                 CarId = c.Id,
                                 CustomerId = d.Id,
                                 RentDate = a.RentDate,
                                 
                             };
                return result.ToList();


            
            }

            



            }

       
       
    }
}
