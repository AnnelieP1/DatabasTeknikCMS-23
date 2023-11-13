using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models;

internal class Categories
{
    public int CategoryId { get; set;}
    public string CategoryType { get; set; } = null!;
    public string CategoryDescription { get; set; } = null!;

}
