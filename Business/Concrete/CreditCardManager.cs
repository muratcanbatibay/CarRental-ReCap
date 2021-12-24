using Business.Abstract;
using Business.Contants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        [ValidationAspect(typeof(CreditCardValidator))]
        public IResult Add(CreditCard card)
        {
            if (card.CardNumber.Length <=11)
            {
                return new ErrorResult(Messages.CardLengthError);
            }
            _creditCardDal.Add(card);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(CreditCard card)
        {
            _creditCardDal.Delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<CreditCard>> GetAllDetails()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }

        public IDataResult<List<CreditCard>> GetByCardName(string firstName, string lastName)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(p => p.FirstName == firstName && p.LastName == lastName));
        }

        public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(p => p.CardNumber == cardNumber));
        }

       

        public IResult Update(CreditCard card)
        {
            _creditCardDal.Update(card);
            return new SuccessResult(Messages.CardUpdated);

        }
    }
}
