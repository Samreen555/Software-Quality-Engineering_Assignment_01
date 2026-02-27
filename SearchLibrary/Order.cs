using System;

namespace SearchLibrary
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }

        public Order(int orderId, string customerName, double amount) 
        {
            OrderId = orderId;
            CustomerName = customerName;
            Amount = amount;
        }
    }
}