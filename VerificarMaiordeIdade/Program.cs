using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarMaiordeIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int qtd = 0;
            int i = 0;
            
            while (i < 10)
            {
                i++;
                Console.WriteLine("Informe as idades: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if(idade >= 18)
                {
                    qtd++;
                }
                 
            }
            Console.WriteLine("Foi informado " + qtd + " idades maiores que 18");
            Console.ReadKey();

        }
    }
}
