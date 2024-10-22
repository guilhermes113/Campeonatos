using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;

namespace Campeonatos.Models
{
    public class Organizador : Cadastro
    {
        public Organizador(string name, string number, string email)
           : base(name, number, email)
        {
        }


    }
}
