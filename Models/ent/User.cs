using Microsoft.AspNetCore.Identity;

namespace elforo_be.Models.ent
{
    
    public class User : IdentityUser
    {
        public String? Nombre {get; set;}
        public String? Apellido {get; set;}
        public DateOnly Nacimiento {get; set;}
        public DateOnly Ingreso {get; set;}
        public String? Doc {get; set;}
        public List<Subject>? Subjects {get; set;}
    }

}