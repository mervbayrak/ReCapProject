using CarRentalSystem.Business.Concrete;
using CarRentalSystem.DataAccess.Concrete.EntityFramework;
using CarRentalSystem.Entities.Concrete;
using System;

namespace CarRentalSystem.ConsoleUI
{
    class Program
    {
        private static Business.Concrete.EfBrandDal _carManager;
        static void Main(string[] args)
        {
            _carManager = new Business.Concrete.EfBrandDal(new EfCarDal());


            CarDetailList();
        }


        static void CarDetailList()
        {
            var result = _carManager.GetProductDetails();

            if (result.Success == true)
            {

                foreach (var item in result.Data)
                {
                    Console.WriteLine("Name:{0} Marka: {1} Renk: {2} Fiyat: {3} ", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }


        static void CarAllList()
        {
            var result = _carManager.GetAll();

            if (result.Success == true)
            {

                foreach (var item in result.Data)
                {
                    Console.WriteLine("Id: {0} Name:{6} Marka: {1} Renk: {2} Model: {3} Fiyat: {4} Açıklama: {5}", item.Id, item.Brand.Name, item.Color.Name, item.ModelYear, item.DailyPrice, item.Description, item.Name);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }


        static void CarAdd(Car addCar)
        {
            var result = _carManager.Add(addCar);

            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
           
        }


        static void CarUpdate(Car updateCar)
        {
            var result = _carManager.Update(updateCar);

            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }


        static void CarDelete(Car deleteCar)
        {
            var result = _carManager.Delete(deleteCar);

            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
