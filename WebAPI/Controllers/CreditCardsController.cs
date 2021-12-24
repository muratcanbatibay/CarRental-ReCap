using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        ICreditCardService _creditCardService;

        public CreditCardsController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        
        [HttpPost("addtocard")]
        public IActionResult Add(CreditCard card)
        {
            var result = _creditCardService.Add(card);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("deletetocard")]
        public IActionResult Delete(CreditCard card)
        {
            var result = _creditCardService.Delete(card);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("updatetocard")]
        public IActionResult Update(CreditCard card)
        {
            var result = _creditCardService.Update(card);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

       

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _creditCardService.GetAllDetails();
            if (result.Success)
            {
                return Ok(result);



            }
            return BadRequest(result);
        }

        [HttpGet("getbyname")]
        public IActionResult GetByCardName(string firstName, string lastName)
        {
            var result = _creditCardService.GetByCardName(firstName,lastName);
            if (result.Success)
            {
                return Ok(result);



            }
            return BadRequest(result);
        }

        [HttpGet("getbynumber")]
        public IActionResult GetByCardNumber(string cardNumber)
        {
            var result = _creditCardService.GetByCardNumber(cardNumber);
            if (result.Success)
            {
                return Ok(result);



            }
            return BadRequest(result);
        }

      


    }
}
