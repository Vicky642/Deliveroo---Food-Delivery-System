using Deliveroo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to associate the order with a user
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCompleted { get; set; }
        public string DeliveryAddress { get; set; }
        public string PaymentMethod { get; set; }
        public User User { get; set; } // Many-to-One relationship with User
    }
}
