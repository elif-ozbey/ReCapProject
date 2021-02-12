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
            CarManager carManager = new CarManager(new EfCarDal()); //bu inmemory calisacagim demek

            foreach (var car in carManager.GetById(1)) 
            {
                Console.WriteLine(car.DailyPrice);
                
            }

            foreach (var car in carManager.GetByDailyPrice(10,12))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}


