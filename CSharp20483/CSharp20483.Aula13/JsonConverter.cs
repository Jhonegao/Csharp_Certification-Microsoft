using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Aula13
{
    public class JsonConverter
    {
        //Install-Package Newtonsoft.Json
        public void Executa()
        {
            Console.WriteLine("Serialização de Objetos para Json");

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome="Maykon", Sobrenome="Granemann", Idade=17 },
                new Pessoa { Nome="Dyego", Sobrenome="Rauen", Idade=17 },
                new Pessoa { Nome="Zé", Sobrenome="DasCoves", Idade=17 }
            };

            #region Json
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string json = Serializa(pessoas);
            string jsonArq = "";
            List<Pessoa> listaPessoas = new List<Pessoa>();
            List<Pessoa> pessoasb = new List<Pessoa>(); 

            Parallel.Invoke(
                            () => SalvarArquivo("Pessoas.json", json),
                            () => jsonArq = LerArquivo("Pessoas.json"),
                            () => listaPessoas = Deserializa(jsonArq),
                            () => ConverterParaBinario(pessoas),
                            () => pessoasb = ConverterDeBinario(),
                            () => Parallel.ForEach(listaPessoas, item =>
                            {
                                Console.WriteLine($"Pessoa Parapel : { item.Nome}");
                            }),
                            );
            Parallel.ForEach

            #endregion
            sw.Stop();
            Console.WriteLine($"Temspo de execução Json:{(sw.ElapsedMilliseconds / 1000)} ");
            #region Binario
            // Chamar um método de conversão para Binario
            // Salvar o arquivo em formato binario

            Console.WriteLine($"Convertido Binario Pessoas");
            foreach (var item in pessoasb)
            {
                Console.WriteLine($"Nome: {item.Nome} Sobrenome {item.Sobrenome}");
            }
            sw.Stop();
            Console.WriteLine($"Temspo de execução Binario:{(sw.ElapsedMilliseconds / 1000)} ");
            // Ler do arquivo em formato binario
            // Converter de binario para objeto 
            #endregion
        }

        private void ConverterParaBinario(List<Pessoa> lista)
        {
            var bc = new BinaryFormatter();
            using (var fs = new FileStream("Pessoa.bin", FileMode.Create, FileAccess.Write))
            {
                bc.Serialize(fs, lista);
            }
        }
        private List<Pessoa> ConverterDeBinario()
        {
            List<Pessoa> lista = new List<Pessoa>();
            var bc = new BinaryFormatter();
            using (var fs = new FileStream("Pessoa.bin", FileMode.Open, FileAccess.Read))
            {
                lista = (List<Pessoa>)bc.Deserialize(fs);
            }
            return lista;
        }

        public static void ConverterParaBinario(object objeto)
        {
            var bc = new BinaryFormatter();
            using (var fs = new FileStream("Pessoa.bin", FileMode.Create, FileAccess.Write))
            {
                bc.Serialize(fs, objeto);
            }
        }


        private string LerArquivo(string nomeArquivo)
        {
            string dados;
            using (var sr = new StreamReader(nomeArquivo))
            {
                dados = sr.ReadToEnd();
            }
            return dados;
        }

        private static void SalvarArquivo(string nomeArquivo, string dados)
        {
            Console.WriteLine(dados);
            using (var sw = new StreamWriter(nomeArquivo))
            {
                sw.Write(dados);
            }
        }

        string Serializa<T>(List<T> lista)
        {
            string pessoaJson = JsonConvert.SerializeObject(lista);
            System.Threading.Thread.Sleep(1000);
            return pessoaJson;
        }
        List<Pessoa> Deserializa(string json)
        {
            var objetos = JsonConvert.DeserializeObject<List<Pessoa>>(json);
            return objetos;
        }
    }
}

