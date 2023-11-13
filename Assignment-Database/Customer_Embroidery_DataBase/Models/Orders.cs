using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models
{
    internal class Orders
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerPhoneNumber { get; set; } = null!;
        public string TotalAmount { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
    }
}
