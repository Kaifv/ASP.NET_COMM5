using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_COMM5.Models
{
    //Creating class for my customers
    public class Customer
    {
        //Customer ID for ym customer table 
        public int customerId { get; set; }

        //Customer Name for my customer table
        public string name { get; set; }

        //This is my date of purchase attribute column
        [Column(TypeName = "Date")]
        public DateTime dateOfPurchase { get; set; }

        //This will be storing the name of the product bought
        public string itemPurchased { get; set; }

        //This will be storing the quantity of the product that i bought
        public int quantity { get; set; }

        //This will store the price of the product that has been purchased
        public decimal price { get; set; }



    }
}
