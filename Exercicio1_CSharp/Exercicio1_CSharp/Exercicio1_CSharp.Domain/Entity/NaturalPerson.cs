using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Domain.Entities
{
    public class NaturalPerson : Person
    {
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }


    }
}
