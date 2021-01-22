using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email alanı boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password alanı boş geçilemez")]
        [MaxLength(20)]
        [MinLength(3)]
        public string Password { get; set; }
    }
}
