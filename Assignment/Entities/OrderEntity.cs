using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    [Index(nameof(OrderName), IsUnique = true)]
    internal class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string OrderName { get; set; } = null!;
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

    }
}
    