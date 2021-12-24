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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalCarContext>, ICarDal
    {
       

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join i in context.CarImages
                             on c.CarId equals i.CarId
                             
                             
                             

                             select new CarDetailDto
                             {
                                 ColorId = co.ColorId,
                                 BrandId = b.BrandId,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 CarName = c.CarName,
                                 CarId=c.CarId,
                                 ImagePath=i.ImagePath
                             };

                return result.ToList();
                
            }
            
        }
          

        }


    }


    

