using System;
using System.Collections.Generic;

namespace BookStoreBO
{
    public class OrderItemSummary
    {
        public string TitleId { get; set; } = "";
        public string Title { get; set; } = "";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }   
        public decimal LineTotal { get; set; }  
    }

    public class OrderSummary
    {
        public string OrderNumber { get; set; } = "";
        public string StoreId { get; set; } = "";
        public string StoreName { get; set; } = "";
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; }

        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        public List<OrderItemSummary> Items { get; set; } = new();
    }
}
