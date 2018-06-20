using System;
using System.Collections.Generic;
using System.Text;

namespace CGSFA.Domain.Entities
{
    public class PessoaTelefone
    {
        public long? TelefoneId { get; set; }

        public string Numero { get; set; }

        public bool Principal { get; set; }

        
    }
}
