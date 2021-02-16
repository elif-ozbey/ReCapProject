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

            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + " " + car.BrandName + " " + car.ColorName + " " + car.Description);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
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


