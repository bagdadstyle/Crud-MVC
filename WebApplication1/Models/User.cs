using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string CellPhone { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
    }
}
