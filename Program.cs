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

            Console.Write("Digite sua idade: ");
            idade = Int16.Parse(Console.ReadLine());
            
            FileInfo ar = new FileInfo("dados_cabecalho.csv");
            
            StreamWriter arquivo;
        
            if(ar.Exists){
            //Criando o arquivo csv para gravar os dados.
            arquivo = new StreamWriter("dados_cabecalho.csv", true);
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            }
            //Escreve o Cabeçalho caso seja a primeira execução.
            else{
            arquivo = new StreamWriter("dados_cabecalho.csv", true);
            arquivo.WriteLine("Nome;E-mail;Idade;Data;");
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            }

            arquivo.Close();
             
        }
    }
}
