using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Troca(int[] vetor, int pos1, int pos2)
        {
            int aux = 0;
            aux = vetor[pos1];
            vetor[pos1] = vetor[pos2];
            vetor[pos2] = aux;


        }
        static void Imprime(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i] + "\t");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            int[] vetor = new int[] { 10, 351, 3, 1500, 50 };

            Imprime(vetor);//vetor não alterado

            int insPos1;
            int insPos2;
            do
            {

                Console.WriteLine("Função troca de posições\nInsira primeira posição: ");
                insPos1 = Int32.Parse(Console.ReadLine());


            } while (insPos1 < 0 || insPos1 > vetor.Length);
            Console.WriteLine("Seu primeiro numero é: " + vetor[insPos1] + " e Esta na posição: " + insPos1);



            do
            {
                Console.WriteLine("Insira segunda posição posição: ");
                insPos2 = Int32.Parse(Console.ReadLine());
            } while (insPos2 < 0 || insPos2 > vetor.Length);
                                
           
           Console.WriteLine("Seu Segundo numero é: " + vetor[insPos2] + " e Esta na posição: " + insPos2);
          
        

                           
                Troca(vetor, insPos1, insPos2);//comando de alteração
                Imprime(vetor);//vetor alterado
            





            Console.ReadKey();
        }
    }
}
