using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models
{
    public class User : Cadastro
    {
        User(string nome)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        [Display(Name = "Nome")]
        public string Nome { get; private set; }
        [Display(Name = "Número")]
        public string numero { get; private set; }
        [Display(Name = "Email")]
        public string email { get; private set; }
        [Display(Name = "Campeonatos jogados")]
        public int camps { get; private set; }
        [Display(Name = "Campeonatos Ganhos")]
        public int Win { get; private set; }
        [Display(Name = "Campeonatos Perdidos")]
        public int lose { get; private set; }
        [Display(Name = "Melhor Posição")]
        public int melhor { get; private set; }



        public void AtualizarDados(string nome)
        {
            Nome = nome;
            DataAlteracao = System.DateTime.Now;
        }
    }
}

