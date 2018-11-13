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


            int[] vetor = new int[] { 10, 351, 3, 1500,50 };

            
            Console.WriteLine("Função troca de posições\nInsira primeira posição: ");
            int insPos1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira segunda posição posição: ");
            int insPos2 = Int32.Parse(Console.ReadLine());
            

            if(insPos1 > vetor.Length || insPos2 > vetor.Length)
            {
                Console.WriteLine("Posição não existe");
            }
            else
            {
                Console.WriteLine("Seu primeiro numero é: " + vetor[insPos1] + " e Esta na posição: " + insPos1);
                Console.WriteLine("Seu Segundo numero é: " + vetor[insPos2] + " e Esta na posição: " + insPos2);

                Imprime(vetor);//vetor não alterado
                Troca(vetor, insPos1, insPos2);//comando de alteração
                Imprime(vetor);//vetor alterado
            }





            Console.ReadKey();
        }
    }
}
