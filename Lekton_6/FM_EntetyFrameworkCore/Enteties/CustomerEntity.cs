using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFrameworkCore.Enteties;


[Index(nameof(Email), IsUnique = true)]
internal class CustomerEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public int CustomerTypeId { get; set;}
    public CustomerTypeEntity CustomerType { get; set; } = null!;

}
