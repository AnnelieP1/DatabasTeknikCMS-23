using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties
{
    internal class UserEntity
    {
        [Key]

        public int UserId { get; set; }
        [Required]
        public string Role { get; set; } = null!;
        [Required]
        public string? NewCustomer {  get; set; }
        [Required]
        public string? ExistingCustomer { get; set; }
        [Required]
        public ICollection<CustomerTypeEntity> customerTypeEntities { get; set; } = new List<CustomerTypeEntity>();
    }
}
