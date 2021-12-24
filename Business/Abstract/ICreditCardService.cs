using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditCardService
    {

      IDataResult<List<CreditCard>> GetAllDetails();
      IDataResult<List<CreditCard>> GetByCardName(string firstName, string lastName);
      IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber);


       IResult Add(CreditCard card);
       IResult Delete(CreditCard car);
       IResult Update(CreditCard card);

    }
}
