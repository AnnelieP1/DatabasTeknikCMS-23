using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;

[Index(nameof(SubCategoryName), IsUnique = true)]

internal class SubCategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string SubCategoryName { get; set; } = null!;
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
}
