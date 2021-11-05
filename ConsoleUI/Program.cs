using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //CarManager carManager = new CarManager(new EfCarDal());
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //UserManager userManager = new UserManager(new EfUserDal());
            //RentalManager rental = new RentalManager(new EfRentalDal());
            //  AddTest(brandManager, colorManager, carManager);
            //  CarDetailTest(carManager);
            //CustomerAndUserAddTest(customerManager, userManager);
            // RentalAddTest(rental);




        }

        //       private static void RentalAddTest(RentalManager rental)
        //        {
        //            rental.Update(new Rental { CarName = "BMW 1.8", CarId = 1, CustomerId = 1, RentalId = 1, RentDate = new DateTime(2021, 09, 10), ReturnDate = new DateTime(2021, 09, 12) });
        //            var result = rental.GetRentalDetails();
        //            foreach (var rent in result.Data)
        //            {
        //                Console.WriteLine(rent.CarName + "/" + rent.CustomerId + "/" + rent.RentalId + "/" + rent.RentDate + "/" + rent.ReturnDate);

        //            }
        //        }

        //        private static void CustomerAndUserAddTest(CustomerManager customerManager, UserManager userManager)
        //        {
        //            customerManager.Add(new Customer { CustomerId = 1, CompanyName = "Asvel ltd." });
        //            userManager.Add(new User { Id = 1, FirstName = "Mustafa", LastName = "Ahke", Email = "mustafaahke@gmail.com"  Password = 123456 });
        //        }

        //        private static void CarDetailTest(CarManager carManager)
        //        {
        //            var result = carManager.GetCarDetails();
        //            if (result.Success)
        //            {
        //                foreach (var car in result.Data)
        //                {
        //                    Console.WriteLine(car.CarName + " / " + car.DailyPrice);
        //                }
        //            }
        //            else
        //            {

        //                Console.WriteLine(result.Message);

        //            }
        //        }

        //        private static void AddTest(BrandManager brandManager, ColorManager colorManager, CarManager carManager)
        //        {
        //            carManager.Add(new Car
        //            {
        //                CarId = 1,
        //                BrandId = 1,
        //                ColorId = 1,
        //                CarName = "BMW 1.8",
        //                DailyPrice = 200,
        //                ModelYear = "2015",
        //                Description = "v8 MOTOR"
        //            });
        //            carManager.Add(new Car
        //            {
        //                CarId = 2,
        //                BrandId = 2,
        //                ColorId = 2,
        //                CarName = "Audi A6",
        //                DailyPrice = 250,
        //                Description = "1.6 Turbo",
        //                ModelYear = "2017"

        //            });
        //            carManager.Add(new Car
        //            {
        //                CarId = 3,
        //                BrandId = 1,
        //                ColorId = 2,
        //                CarName = "Audi R8",
        //                DailyPrice = 250,
        //                Description = "1.4 Turbo",
        //                ModelYear = "2016"

        //            });


        //            brandManager.Add(new Brand { BrandId = 1, BrandName = "BMW" });
        //            brandManager.Add(new Brand { BrandId = 2, BrandName = "AUDI" });
        //            colorManager.Add(new Color { ColorId = 1, ColorName = "Beyaz" });
        //            colorManager.Add(new Color { ColorId = 2, ColorName = "Siyah" });
        //        }
        //    }
    }
}

