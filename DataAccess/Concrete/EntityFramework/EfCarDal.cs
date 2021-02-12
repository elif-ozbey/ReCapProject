using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.BrandId
                             join d in context.Colors
                             on p.BrandId equals d.ColorId
                             select new CarDetailDto
                             {
                                 Id= p.Id, BrandName=c.BrandName, ColorName=d.ColorName, DailiyPrice=p.DailyPrice, Description=p.Description

                             };
                return result.ToList();
            }
        }
    }
}
