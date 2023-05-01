using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TurkeyDB.Model
{
    public class Fruit
    {
        [Key]
        public int FruitID { get; set; }

        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Meyve"), StringLength(50, MinimumLength = 3, ErrorMessage = "{0, {2}-{1} karakter olmalı}")]
        public string FruitName { get; set; }
    }
}
