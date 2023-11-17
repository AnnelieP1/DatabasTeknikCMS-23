using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }
    }
}
