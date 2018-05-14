using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Criar lista do tipo Pessoa
            List<Pessoa> pessoas = new List<Pessoa>();

            //Instanciar a classe
            Pessoa p = new Pessoa();

            //Atribui valores
            p.nome = "Janaina";
            p.idade = "22";

            //Adiciona o objeto na lista
            pessoas.Add(p);

            //Instanciando a classe listaPessoas
            ListaPessoas pe = new ListaPessoas();

            //usuario da sessao
            String usuario = "Pessoa 1";


            //hashmap
            //Dictionary<string, List<Pessoa>> hash = new Dictionary<string, List<Pessoa>>();

            //Método --- public Dictionary<string, List<Pessoa>> adicionaPessoas = new Dictionary<string, List<Pessoa>>();

            //Método da classe listaPessoas que com o hashmap adiciona chave e valor
            pe.adicionaPessoas.Add(usuario, pessoas);


            //ver como o foreach pode vasculhar essa lista, porque da erro no "in hash, qualquer coisa deixa o método aqui mesmo e nao usa o da classe listapessoas
            //troquei o hash por pe.adicionaPessoas e foi    

            foreach (var item in pe.adicionaPessoas)
            {
                foreach (var item2 in pessoas)
                {
                    Console.WriteLine("Chave: " + item.Key + "| Valores - Nome: " + item2.nome + "| Idade: " + item2.idade);
                }

            }

        }
    }
}
