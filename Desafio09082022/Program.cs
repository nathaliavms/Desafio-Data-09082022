using System;


namespace Exercicio
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calculadora IMC");
            Console.WriteLine("2 - Calculadora Area Circulo");
            Console.WriteLine("3 - Calculadora regra de 3");
            Console.WriteLine("4 - Sair");

            return int.Parse(Console.ReadLine());

        }

        static string RetornaClassificacaoImc(double a, double b)
        {
            double calculo;
            

            calculo = a / (b * b);

            if (calculo < 18.50)
            {
                return "Você está abaixo do peso";
            }
            else if (calculo < 25.00)
            {
                return "Você está com o peso normal";
            }
            else if (calculo < 30)
            {
                return "Você está com sobrepeso";
            }
            else if (calculo < 35)
            {
                return "Você está com obesidade grau I";
            }
            else if (calculo < 40)
            {
                return "Você está com obesidade grau II";
            }
            else if (calculo >= 40)
            {
                return "Você está com obesidade grau III";
            }
            else
            {
                return "Invalido";
            }
        }

        static void CalcularImc()
        {
            Console.WriteLine("Digite seu peso:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RetornaClassificacaoImc(a, b));
        }

        static void CalcularArea()
        {
            
            Console.WriteLine("Informe o raio do circulo");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(RetornarArea(a));

        }

        static double RetornarArea(double a)
        {
            double resultado;
            resultado = 3.14 * (a * a);
            return resultado;
        }

        static void CalcularRegra3()
        {
            
            Console.WriteLine("Informe valores A, B e C (na mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            double a = double.Parse(vet2[0]);
            double b = double.Parse(vet2[1]);
            double c = double.Parse(vet2[2]);
            Console.WriteLine(RetornarRegra3(a,b,c));

        }

        static double RetornarRegra3(double a, double b, double c)
        {
            double resultado;
            resultado = (a * c) / b;

            return resultado;
        }

        static void Main(string[] args)
        {
            var a = Menu();

            if (a == 1)
            {
                CalcularImc();
 
            }

            else if (a == 2)
            {
                CalcularArea();
            }

            else if (a == 3)
            {
                CalcularRegra3();

            }
            else 
            {
                Console.WriteLine("FINALIZADO COM SUCESSO!");
            }
        }

    }

}
