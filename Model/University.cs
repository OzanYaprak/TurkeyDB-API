using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TurkeyDB.Model
{
    public class University
    {
        [Key]
        public int UniversityId { get; set; }

        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Üniversite Adı"), StringLength(100, MinimumLength = 9, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string UniversityName { get; set; }

        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "İnternet sitesi"), StringLength(200, MinimumLength = 20, ErrorMessage = "{0} {2} - {1} karakter olmalı")]
        public string WebUrl { get; set; }

        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Telefon No "), StringLength(16, MinimumLength = 11, ErrorMessage = "{0}  {2} - {1} karakter olmalı.")]
        public string TelephoneNumber { get; set; }

    }
}
