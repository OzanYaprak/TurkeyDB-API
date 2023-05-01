using System.ComponentModel.DataAnnotations;

namespace TurkeyDB.Model
{
    public class Mountain
    {
        [Key]

        public int MountainID { get; set; }


        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Dağ"), StringLength(70, MinimumLength = 2, ErrorMessage = "{0, {2}-{1} karakter olmalı}")]
        public string MountainName { get; set; }

        //[Required(ErrorMessage = "{0} gerekli"), Display(Name = "Ülke"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0, {2}-{1} karakter olmalı}")]
        //public string Country { get; set; }


    }
}
