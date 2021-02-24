using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car
            {                
                ModelYear = 2019,
                DailyPrice=200,
                Description="1 yıllık Ehliyet Gerekli",
                BrandId=1,
                ColorId=2
            };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.ModelYear);
            }
        }
    }
}
