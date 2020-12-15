using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_COMM5.Models
{
    public class Order
    {
        //This will be storing the order id, which will also be the primary key for my this table
        public int orderID { get; set; }

        //This will be sotring the date at which the order was placed
        public DateTime dateOrderPlaced { get; set; }

        //This will be storing the date at which the payment was made
        public DateTime dateOrderPaid { get; set; }

        //This will store the method of the payment at the product was bought
        public string paymentMethod { get; set; }

        //Thi is helpful for making the foreign key in this table relating to another one 
        public Customer Customer { get; set; }

        //I am specifying the foreign key in this context
        [ForeignKey("Customer")]
        public int CustomerFK { get; set; }

        
    }
}
