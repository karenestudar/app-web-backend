using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
