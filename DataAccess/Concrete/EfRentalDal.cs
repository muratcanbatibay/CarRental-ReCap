using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalCarContext>, IRentalDal
    {
        

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentalCarContext context= new RentalCarContext() )
            {

                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.CarName equals r.CarName
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             select new RentalDetailDto
                             { CarId = c.CarId, CustomerId = cu.CustomerId, RentalId = r.RentalId, RentDate = r.RentDate, ReturnDate = r.ReturnDate };


                return result.ToList();


            }




        }
    }
}
