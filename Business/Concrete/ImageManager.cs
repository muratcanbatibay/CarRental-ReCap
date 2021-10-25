using Business.Abstract;
using Business.Contants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IFileHelper _fileHelper;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, Image carImage)
        {
            IResult result = BusinessRule.Run(CheckIfCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, ImagePath.UploadImagePath);
            carImage.Date = DateTime.Now;
            _imageDal.Add(carImage);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(Image carImage)
        {
            _fileHelper.Delete(ImagePath.UploadImagePath + carImage.ImagePath);
            _imageDal.Delete(carImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, Image carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file,ImagePath.UploadImagePath + carImage.ImagePath,ImagePath.UploadImagePath);
            _imageDal.Update(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetByCarId(int carId)
        {
            var result = BusinessRule.Run(CheckCarImage(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<Image>>(GetDefaultImage(carId).Data);
            }
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<Image> GetByImageId(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(c => c.CarId == imageId));
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }
        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        private IDataResult<List<Image>> GetDefaultImage(int carId)
        {

            List<Image> carImage = new List<Image>();
            carImage.Add(new Image { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<Image>>(carImage);
        }
        private IResult CheckCarImage(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

       
    }
}

