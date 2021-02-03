using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()); //bu inmemory calisacagim demek

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                
            }

            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine("Araç Adı : {0}\nGünlük ücreti: {1} TL\n\n", car.Description, car.DailyPrice);
            }
        }
    }
}


