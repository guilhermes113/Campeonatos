using Campeonatos.Models.Interface;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Campeonatos.Models
{
    public class Gestor : Cadastro
    {
        public Gestor(string name, string number, string email)
                : base(name, number, email)
        {
        }
    }
}
