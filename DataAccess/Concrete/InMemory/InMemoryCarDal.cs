using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car> {
            new Car { Id = 1 , BrandId=1, ColorId=2, DailyPrice=3, ModelYear="2020", Description="Spor" },
            new Car { Id = 2 , BrandId=1, ColorId=3, DailyPrice=5, ModelYear="2021", Description="Klasik" },
            new Car { Id = 3 , BrandId=2, ColorId=1, DailyPrice=4, ModelYear="2018", Description="Sifir" },
            new Car { Id = 4 , BrandId=3, ColorId=4, DailyPrice=6, ModelYear="2016", Description="Sedan" }
            };


        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CartoDelete= _Cars.SingleOrDefault(p=>p.Id==car.Id); //silinecek olan araba id nin referansini bulduk. p ile referanslarda gezindik silinmek istenen car Id sini cartodelete atadik
            _Cars.Remove(CartoDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetById(int carId)
        {
            return _Cars.Where(p=>p.Id==carId).ToList();
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _Cars.Where(p => p.BrandId == brandId).ToList(); //BrandId lerde gezinmemizi sagladi, istenen markalarda sonuc dondurur
        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
