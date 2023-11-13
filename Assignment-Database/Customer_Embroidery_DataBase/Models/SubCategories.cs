using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models;

internal class SubCategories
{
    public int CategoryId { get; set; }
    public int SubCategoryId { get; set; }
    public string SubcategoryName { get; set; } = null!;
    public string SubcategoryDescription { get; set;} = null!;

}
