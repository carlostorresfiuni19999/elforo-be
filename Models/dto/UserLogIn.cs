using System.ComponentModel.DataAnnotations;

namespace elforo_be.Models.dto
{
    public class UserLogin
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress(ErrorMessage = "Formato Email no valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El Password es requerido")]
        public string? Password { get; set; }
    }
}