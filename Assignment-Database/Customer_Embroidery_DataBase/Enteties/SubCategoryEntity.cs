using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties
{
    internal class SubCategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public int CategoryId { get; set; }

        public string SubCategoryName { get; set; } = null!;
        [Required]
        public string SubCategoryDescription { get; set;} = null!;

        [Required]
        public ICollection<SubCategoryEntity> SubCategories { get; set; } = new List<SubCategoryEntity>();



    }
}
