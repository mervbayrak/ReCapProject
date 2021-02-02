using CarRentalSystem.Business.Concrete;
using CarRentalSystem.DataAccess.Concrete.InMemory;
using System;

namespace CarRentalSystem.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                string strCarList = String.Format("Id: {0} Marka: {1} Renk: {2} Model: {3} Fiyat: {4} Açıklama: {5}",
                    item.Id, item.Brand.BrandName, item.Color.ColorName, item.ModelYear, item.DailyPrice, item.Description);

                Console.WriteLine(strCarList);
            }
        }
    }
}
