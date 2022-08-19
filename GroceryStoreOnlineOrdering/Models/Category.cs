using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreOnlineOrdering.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required!")]
        public string Name { get; set; }

    }
}

