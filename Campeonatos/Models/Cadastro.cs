using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Campeonatos.Models
{
    public class Cadastro : IEntidade
    {
        protected Cadastro(string name, string number, string email)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Name = name;
            Number = number;
            Email = email;
        }
        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        [Display(Name = "Nome")]
        public string Name { get; private set; }

        [Display(Name = "Número")]
        public string Number { get; private set; }

        [Display(Name = "Email")]
        public string Email { get; private set; }


        public void AtualizarDados(string name, string number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
            DataAlteracao = System.DateTime.Now;
        }

    }
}
