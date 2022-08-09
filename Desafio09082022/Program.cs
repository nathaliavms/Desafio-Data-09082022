using System;

namespace Desafio09082022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código de DDD para discagem interurbana:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(DddInformado(a));  
            
        }

        static string DddInformado(int a)
        {

            if (a == 61)
            {
                return "Brasilia";
            }
            else if (a == 71)
            {
                return "Salvador";
            }
            else if (a == 11)
            {
                return "Sao Paulo";
            }
            else if (a == 21)
            {
                return "Rio de Janeiro";
            }
            else if (a == 32)
            {
                return "Juiz de Fora";
            }
            else if (a == 19)
            {
                return "Campinas";
            }
            else if (a == 27)
            {
                return "Vitoria";
            }
            else if (a == 31)
            {
                return "Belo Horizonte";
            }
            else
            {
                return "DDD nao cadastrado";
            }

          
        }
    }
}
