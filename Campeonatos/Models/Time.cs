using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models
{
    public class Time : IEntidade
    {
        public Time(string name)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Name = name;
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        [Display(Name = "Nome do Time")]
        public string Name { get; private set; }

        [Display(Name = "Participantes")]
        public string Participants { get; private set; }

        [Display(Name = "Campeonatos jogados")]
        public int Games { get; private set; }

        [Display(Name = "Campeonatos Ganhos")]
        public int Wins { get; private set; }

        [Display(Name = "Campeonatos Perdidos")]
        public int Losers { get; private set; }

        [Display(Name = "Melhor Camp")]
        public int TopGame { get; private set; }
        public void AtualizarDados(string name)
        {
            Name = name;
            DataAlteracao = System.DateTime.Now;
        }
    }
}
