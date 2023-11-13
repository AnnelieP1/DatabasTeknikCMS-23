using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models;

internal class Admins
{
   
    public int Id { get; set; }
    public string AdminName { get; set; } = null!;
    public string Password { get; set; } = null!;

}
