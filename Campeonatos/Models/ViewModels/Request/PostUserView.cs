using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models.ViewModels.Request
{
    public class PostUserView
    {
        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter de 3 a 50 caractéres")]
        public  string Name { get; set; }
        public  string Email { get; set; }
        public  string Number { get; set; }
    }
}
