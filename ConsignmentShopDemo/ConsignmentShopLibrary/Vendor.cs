using System;
using System.Collections.Generic;
using System.Text;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public Vendor()
        {
            Commission = .5;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Commission { get; set; }
    }
}
