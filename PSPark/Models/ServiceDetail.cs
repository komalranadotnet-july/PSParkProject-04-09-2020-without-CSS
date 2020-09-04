using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSPark.Models
{
    public class ServiceDetail
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public float ServicePrice { get; set; }
        public AddService AddService { get; set; }
        public int AddServiceId { get; set; }
    }
}