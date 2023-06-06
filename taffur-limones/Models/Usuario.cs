using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taffur_limones.Models
{
    public class Usuario
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string nombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string clave { get; set; }

        [Required]
        public bool estado { get; set; }

        public int generoId { get; set; }

        public Genero genero { get; set; }
    }
}
