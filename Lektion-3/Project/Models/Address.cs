using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models;

internal class Address
{
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string postalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
