using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models
{
    public class Organizador : Cadastro
    {
        public Organizador(string nome)
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



        public void AtualizarDados(string nome)
        {
            Nome = nome;
            DataAlteracao = System.DateTime.Now;
        }
    }
}
