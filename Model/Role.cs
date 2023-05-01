using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TurkeyDB.Model
{
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte RoleID { get; set; }


        [Required(ErrorMessage = "{0} gerekli"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0, {2}-{1} karakter olmalı}"), Display(Name = "Rol")]
        public string RoleName { get; set; }
    }
}
