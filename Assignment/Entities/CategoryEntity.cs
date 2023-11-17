using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;

[Index(nameof(CategoryName), IsUnique = true)]
internal class CategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public string? CategoryDescription { get; set; }
    public ICollection<CategoryEntity> SubCategories { get; set; } = new List<CategoryEntity>();


}
