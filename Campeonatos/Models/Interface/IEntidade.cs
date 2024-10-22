
using System;

namespace Campeonatos.Models.Interface
{
    public class IEntidade
    {
        string Id { get; }

        DateTime DataCadastro { get; }
        DateTime DataAlteracao { get; }
    }
}
