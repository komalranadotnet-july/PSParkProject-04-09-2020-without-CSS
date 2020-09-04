using PSPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSPark.ViewModel
{
    public class NewViewModel
    {
        public IEnumerable<AddService> AddServices { get; set; }

        public ServiceDetail ServiceDetail { get; set; }

        public Cars Car { get; set; }

        public ServiceHistory ServiceHistory { get; set; }
    }
}