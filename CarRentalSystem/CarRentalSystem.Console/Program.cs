using CarRentalSystem.Business.Concrete;
using CarRentalSystem.DataAccess.Concrete.EntityFramework;
using CarRentalSystem.Entities.Concrete;
using System;

namespace CarRentalSystem.ConsoleUI
{
    class Program
    {
        private static CarManager _carManager;
        static void Main(string[] args)
        {
            _carManager = new CarManager(new EfCarDal());


            CarDetailList();
        }
        static void CarDetailList()
        {
            try
            {
                foreach (var item in _carManager.GetProductDetails())
                {
                    string strCarList = String.Format("Name:{0} Marka: {1} Renk: {2} Fiyat: {3} ",
                        item.CarName, item.BrandName, item.ColorName, item.DailyPrice);

                    Console.WriteLine(strCarList);
                }
               
            }
            catch (Exception)
            {
                Console.WriteLine("Car nesnesi listeleme işlemi gerçekleştirilemedi.");
            }

        }
        static void CarAllList()
        {
            try
            {
                foreach (var item in _carManager.GetAll())
                {
                    string strCarList = String.Format("Id: {0} Name:{6} Marka: {1} Renk: {2} Model: {3} Fiyat: {4} Açıklama: {5}",
                        item.Id, item.Brand.Name, item.Color.Name, item.ModelYear, item.DailyPrice, item.Description, item.Name);

                    Console.WriteLine(strCarList);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Car nesnesi listeleme işlemi gerçekleştirilemedi.");
            }

        }
        static void CarAdd(Car addCar)
        {
            try
            {
                _carManager.Add(addCar);
            }
            catch (Exception)
            {
                Console.WriteLine("Car nesnesi eklenme işlemi gerçekleştirilemedi.");
            }
           
        }
        static void CarUpdate(Car updateCar)
        {
            try
            {
                _carManager.Update(updateCar);
            }
            catch (Exception)
            {
                Console.WriteLine("Car nesnesi güncelleme işlemi gerçekleştirilemedi.");
            }
        }
        static void CarDelete(Car deleteCar)
        {
            try
            {
                _carManager.Delete(deleteCar);
            }
            catch (Exception)
            {
                Console.WriteLine("Car nesnesi silme işlemi gerçekleştirilemedi.");
            }
        }
    }
}
