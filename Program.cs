using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int idade;


            // Solicitando os dados do usuário.
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o seu E-mail: ");
            email = Console.ReadLine();

            Console.Write("Digite sua idade");
            idade = Int16.Parse(Console.ReadLine());
            
            //Criando o arquivo csv para gravar os dados.
            StreamWriter arquivo = new StreamWriter("dados.csv", true);
            
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            arquivo.Close();

             
        }
    }
}
