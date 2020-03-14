using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            // Chamando metodo para serializar para Json
            string json = Serializa(pessoas);
            // Salvando em arquivo a string em formato Json
            SalvarArquivo("Pessoas.json", json);
            // Lendo do arquivo em Json
            string jsonArq = LerArquivo("Pessoas.json");
            // Chamando o metodo para deserializar a string de Json para Objeto
            var listaPessoas = Deserializa(jsonArq);
            #endregion

            #region Binario
            // Chamar um método de conversão para Binario
            // Salvar o arquivo em formato binario
            ConverterParaBinario(pessoas);

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
            return pessoaJson;
        }
        List<object> Deserializa(string json)
        {
            var objetos = JsonConvert.DeserializeObject<List<object>>(json);
            return objetos;
        }
    }
}

