using System;

namespace Desafio09082022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código de DDD para discagem interurbana:");
            int a = int.Parse(Console.ReadLine());

            int resultado = DddInformado(a);
           
        }

        static int DddInformado(int a) {

            if (a == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (a == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (a == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (a == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (a == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (a == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (a == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (a == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            return a;

        }
    }
}
