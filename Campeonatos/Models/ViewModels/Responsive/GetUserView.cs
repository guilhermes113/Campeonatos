using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models.ViewModels.Responsive
{
    public class GetUserView
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
