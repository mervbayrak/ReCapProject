using CarRentalSystem.Business.Concrete;
using CarRentalSystem.DataAccess.Concrete.EntityFramework;
using CarRentalSystem.Entities.Concrete;
using System;

namespace CarRentalSystem.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                string strCarList = String.Format("Id: {0} Name:{6} Marka: {1} Renk: {2} Model: {3} Fiyat: {4} Açıklama: {5}",
                    item.Id, item.Brand.Name, item.Color.Name, item.ModelYear, item.DailyPrice, item.Description, item.Name);

                Console.WriteLine(strCarList);
            }

            //FluentValidation Testi için
            carManager.Add(new Car());
        }
    }
}
