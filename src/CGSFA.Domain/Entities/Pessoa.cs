using System;
using System.Collections.Generic;
using System.Text;

namespace CGSFA.Domain.Entities
{
    public class Pessoa
    {
        public long? ContatoId { get; set; }

        public String Nome { get; set; }

        public string Cpf { get; set; }

        public bool Dizimista { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }

       
    }
}
