using System.ComponentModel.DataAnnotations;

namespace TurkeyDB.Model
{
    public class Lake
    {
        [Key]
        public int LakeID { get; set; }

        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Göl Adı"), StringLength(50, MinimumLength = 3, ErrorMessage = "{0, {2}-{1} karakter olmalı}")]
        public string LakeName { get; set; }
    }
}
