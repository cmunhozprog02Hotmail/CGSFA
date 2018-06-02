using System;
using System.Collections.Generic;
using System.Text;

namespace CGSFA.Domain.Entities
{
    public class Contato
    {
        public long? ContatoId { get; set; }

        public String Nome { get; set; }

        public string Cep { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Email { get; set; }

        public string Telefone1 { get; set; }

        public string Telefone2 { get; set; }

        public string Telefone3 { get; set; }
    }
}
