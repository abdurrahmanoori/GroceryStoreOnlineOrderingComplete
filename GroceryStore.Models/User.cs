using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GroceryStore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is not allowed to be empty")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password must no be empty.")]
        public string Password { get; set; }
        [Compare(otherProperty: "Password", ErrorMessage = "Passwords are not match!")]
        public string ConfirmPassword { get; set; }
    }
}