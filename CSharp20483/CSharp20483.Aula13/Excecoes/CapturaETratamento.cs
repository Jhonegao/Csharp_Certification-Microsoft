using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Aula13.Excecoes
{
    public class CapturaETratamento
    {
        public void Executa()
        {
            Calc calc = new Calc { N1 = 10, N2 = -1 };
            calc.Divisao();
        }
    }
}
