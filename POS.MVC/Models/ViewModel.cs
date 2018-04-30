using POS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.MVC.Models
{
    public class ViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public string AddressId { get; set; }
    }
}