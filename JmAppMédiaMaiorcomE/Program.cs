using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmAppMédiaMaiorcomE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua média?");
            int media = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua presença?");
            int porcent = int.Parse(Console.ReadLine());

            if (media >= 7 && porcent >= 75)
            {
                Console.WriteLine("Aprovado");
            }

            else if (media < 7 && media >= 4 && porcent >= 75 || media >= 7 && porcent < 75)
            {
                Console.WriteLine("Recuperação");
            }

            else 
            {
                Console.WriteLine("Retido");
            }
        
            Console.ReadKey();
        }


    }
}
