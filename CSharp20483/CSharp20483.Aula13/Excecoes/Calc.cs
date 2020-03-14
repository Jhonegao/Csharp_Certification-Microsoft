using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Aula13.Excecoes
{
    class Calc
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public int Soma()
        {
            return this.N1 + this.N2;
        }
        public int Subtracao()
        {
            return this.N1 - this.N2;
        }
        public int Divisao()
        {
            int resultado = 0;
            try
            {
                if (this.N2 == 0)
                {
                    throw new ArgumentOutOfRangeException("N2", "Zero nao é um valor valido para N2");
                }
                else if (this.N2 < 0)
                {
                    throw new CalcException();
                }
                resultado = this.N1 / this.N2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return resultado;
        }
        public int Multiplicacao()
        {
            return this.N1 * this.N2;
        }
    }


    [Serializable]
    public class CalcException : Exception
    {
        public CalcException() { }
        public CalcException(string message, Exception inner) : base(message, inner) { }
        protected CalcException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public override string Message => "O valor nao pode ser negativo";
    }
}
