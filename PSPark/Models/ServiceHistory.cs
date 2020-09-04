using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSPark.Models
{
    public class ServiceHistory
    {
        public int Id { get; set; }
        public float Miles { get; set; }
        public float TotPrice { get; set; }
        public string Details { get; set; }
        public DateTime DateAdded { get; set; }
    }
}