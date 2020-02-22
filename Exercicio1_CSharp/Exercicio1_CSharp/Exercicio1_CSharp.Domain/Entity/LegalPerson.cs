using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Domain.Entities
{ 
    public class LegalPerson : Person
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
    }
}
