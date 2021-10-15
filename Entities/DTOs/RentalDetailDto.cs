﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int RentalId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CarName { get; set; }


    }
}
