using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties
{
    internal class CustomerTypeEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Role { get; set; } = null!;
        [Required]

        public ICollection<CustomerEntity> Entities { get; set; } = new List<CustomerEntity>();

    }
}
