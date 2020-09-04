﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSPark.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public int? PhoneNo { get; set; }
        public string Email { get; set; }
    }
}