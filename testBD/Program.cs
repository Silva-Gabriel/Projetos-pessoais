using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testBD
{
    static class Program
    {
        static void Main()
        {
            //Declarações e instâncias de objetos
            string nome = "";
            List<string> Nomes = new List<string>();
            StreamWriter escreveNomes = new StreamWriter("C:/BDtxt/ListaNomes.txt");
            StreamReader lerNomes = new StreamReader("C:/BDtxt/ListaNomes.txt");

            //Adicionando nomes a lista
            for(int contador = 1; contador <= 2;contador++)
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();
                Nomes.Add(nome);
            }

            //Adicionando ao arquivo txt
            for(int i = 1;i <= Nomes.Count;i++)
            {
                
            }

            
        


            /*string Nome = "";
            StreamWriter escreveNomes = new StreamWriter("C:/BDtxt/ListaNomes.txt");
            for(int i = 0;i < 2;i++)
            {
               
                Console.Write($"Digite o {i}° nome: ");
                Nome = Console.ReadLine();
                escreveNomes.WriteLine(Nome);
            }
            escreveNomes.Close();

            StreamReader lerNomes = new StreamReader("C:/BDtxt/ListaNomes.txt");

            int NumLine = 0;
            while(lerNomes.ReadLine() != null)
            {
                Console.WriteLine($"Linha {NumLine}: {lerNomes.ReadLine()}");
                NumLine++;
                lerNomes.ReadLine();
            }
            lerNomes.Close();*/
        }

    }
}
