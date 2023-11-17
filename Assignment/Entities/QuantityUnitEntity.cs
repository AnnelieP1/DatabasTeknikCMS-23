using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    [Index(nameof(UnitName), IsUnique = true)]
    internal class QuantityUnitEntity
    {
        [Key]
        public int Id { get; set; }
        public string UnitName { get; set; } = null!;

    }
}
