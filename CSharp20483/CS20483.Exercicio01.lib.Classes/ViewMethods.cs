using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Exercicio01.lib.Classes
{
    public class ViewMethods
    {
        public decimal VenderProduto(int quantidade, decimal comissao, Produto produto, Vendedor vendedor)
        {
            produto.Quantidade -= quantidade;
            decimal valorFinal = produto.Preco * quantidade;
            vendedor.ComissaoTotal += valorFinal * Comissao(comissao);
            valorFinal += (valorFinal * comissao);
            return valorFinal;
        }

        public decimal Comissao (decimal valor)
        {
            return valor/100;
        }

    }
}
