using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Freelancers
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public string TiposServicos { get; set; }
        public string Obervacoes { get; set; }        
    }
}
