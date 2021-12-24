﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>>GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetByCarImages(int carId);
        IDataResult<List<Car>> GetByCarName(string carName);

        IDataResult<List<CarDetailDto>> GetCarDetails();
        

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);



    }
}

