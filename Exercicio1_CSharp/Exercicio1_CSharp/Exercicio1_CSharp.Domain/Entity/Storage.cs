using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Domain.Entities
{
    public class Storage : BaseId
    {
        public Product Product { get; set; }
        public short Amount { get; set; }

    }
}