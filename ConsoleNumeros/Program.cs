using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de números a serem escritos: ");
            int qtd = int.Parse(Console.ReadLine());
            double[] numero = new double[qtd];
            double maiornumero = double.MinValue;
            double menornumero = double.MaxValue;
            for (int j = 0; j<qtd; j++)
            {
                Console.WriteLine("Digite o número: ");
                numero[j] = double.Parse(Console.ReadLine());
             
               
            }
            Console.Write("Números digitados: ");
            for (int j=0; j<qtd; j++)
            {
                Console.Write(numero[j] + "    ");
                if (numero[j] <= menornumero) { menornumero=numero[j];}
                if (numero[j]>=maiornumero) { maiornumero=numero[j]; }
            }
        
            Console.WriteLine("\nMaior número: "+maiornumero);
            Console.WriteLine("Menor número: "+menornumero); 
         
              
            Console.ReadKey();

        }
    }
}
