using Campeonatos.Models.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Campeonatos.Models
{
    public class User : Cadastro
    {
        public User(string name, string number, string email)
           : base(name, number, email)
        {
        }


        public List<TimeUser> TimesUsers { get; set; }
                    
    }
}

