using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            //BrandTest();




            CarManager carManager = new CarManager(new EfCarDal()); //bu inmemory calisacagim demek

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.Id + " " + car.BrandName + " " + car.ColorName + " " + car.Description);

            }
        }
              private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        
    }
}


