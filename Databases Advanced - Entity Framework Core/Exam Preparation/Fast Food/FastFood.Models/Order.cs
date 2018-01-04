using FastFood.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FastFood.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string Customer { get; set; }

        public DateTime DateTime { get; set; }

        public OrderType Type { get; set; } = OrderType.ForHere;

        public decimal TotalPrice => this.OrderItems
            .Select(oi => (decimal)oi.Quantity * oi.Item.Price)
            .Sum();

        public int EmployeeId { get; set; } 
        public Employee Employee { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}