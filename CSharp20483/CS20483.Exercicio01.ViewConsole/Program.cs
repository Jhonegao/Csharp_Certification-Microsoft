using CS20483.Exercicio01.lib.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Exercicio01.ViewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewMethods vm = new ViewMethods();
            EstoqueProduto ep = new EstoqueProduto();
            ListaVendedore lv = new ListaVendedore();
            
            Vendedor vendedor1 = new Vendedor("Jhonata", "Simonetto");
            Produto p1 = new Produto("Apple", 100.00m, 10);
            lv.AdicionarVendedor(vendedor1);
            ep.AdicionarEstoque(p1);
            vm.VenderProduto(5, 10, p1, vendedor1);


            Console.WriteLine("Tecle:" +
                              "\n1 Para cadastrar Produto//" +
                              "\n2 Para Cadastrar vendedor//" +
                              "\n3 Listar todos produtos//" +
                              "\n4 Listar todos vendedors//" +
                              "\n5 Para realizar venda de um produto ja cadastrado//");
       
            string opcao = Convert.ToString(Console.ReadLine());
            //add method while and trim to clean
            if (opcao == "1")
            {
                Console.WriteLine("Digite o nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o valor do Produto: ");
                decimal valorProduto = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite a quantidade em estoque: ");
                int quantidadeProduto = Convert.ToInt32(Console.ReadLine());
                Produto p = new Produto(nomeProduto, valorProduto, quantidadeProduto);
                ep.AdicionarEstoque(p);
                Console.ReadKey();
            }
            else if (opcao =="2") {
                Console.WriteLine("Digite o primeiro nome do Vendedor: ");
                string nomeVendedor = Console.ReadLine();
                Console.WriteLine("Digite o ultimo nome do Vendedor: ");
                string sobrenomeVendedor = Console.ReadLine();
                Vendedor v = new Vendedor(nomeVendedor,sobrenomeVendedor);
                lv.AdicionarVendedor(v);
                Console.ReadKey();
            }
            else if (opcao == "3")
            {
                Console.WriteLine(ep.ToString());
                Console.ReadKey();
            }else if (opcao == "4")
            {
                Console.WriteLine(lv.ToString());
                Console.ReadKey();
            }

            //Console.ReadKey();

        }
    }
}