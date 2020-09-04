using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSPark.Models
{
    public class Cars
    {
        [Key]
        public int CarsId { get; set; }

        public int Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Style { get; set; }
        public int MYear { get; set; }
        public string Color { get; set; }

       



    }
}