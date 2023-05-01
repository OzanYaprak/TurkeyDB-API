using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TurkeyDB.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }


        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Eposta"), StringLength(50, MinimumLength = 6, ErrorMessage = "{0}, {2}-{1} karakter olmalı"), DataType(DataType.EmailAddress, ErrorMessage = "Geçersiz {0}")]
        public string Email { get; set; }



        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0}, {2}{1} karakter olmalı"), DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped, Display(Name = "Şifre Tekrarı"), DataType(DataType.Password), Compare("Passwordd", ErrorMessage = "Şifre ve Şifre Tekrarı aynı değil")]
        public string PasswordRepeat { get; set; }


        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Rol")]
        public byte RoleID { get; set; }


        // NAVIGASYON
        public Role Role { get; set; } 
    }
}
