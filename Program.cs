using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Menu();
        }
       
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação quer realizar? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Calculo de Média");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Media(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
            {
                Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

              float resultado = v1+v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
            }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1-v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao()
        {
           Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    

        static void Media()
        {
            Console.Clear();

            Console.WriteLine("Digite a primeita nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digitea segunda nota: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            float n4 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float res1 = n1+n2+n3+n4;
            float res2 = res1/4;

            Console.WriteLine($"A média do aluno é {res2}");
            Console.ReadKey();
            Menu();
        }
    }
}