using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SharedModels.Models
{
    public class Order
    {
        public Order()
        {
            orderDetails = new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name = "Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Mobile No")]
        public string MobileNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public virtual List<OrderDetails> orderDetails { get; set; }
        [Display(Name="Order Processed")]
        public bool IsProcessed { get; set; }
    }
}