
using System;

namespace Conhecendo_variaveis_e_instrucoes
{

    class Program
    {

        static void Main(string[] args)
        {
            /*
            static void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;
                a = 1;
                Console.WriteLine(a + b + c + d);
            }
            Declaracoes();
            */

            /*
            static void InstrucaoIf()
            {                
                string[] args = {"1", "2", "3"};

                if (args.Length == 0)
                {
                    Console.WriteLine("Nenhum argumento");
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Um argumento");
                }
                else
                {
                    Console.WriteLine($"{args.Length} argumentos");
                }
            }
            InstrucaoIf();
            */

            /*
            static void InstrucaoSwitch()
            {
                string[] args = {"1", "2", "3"};
                int numeroDeArgumentos = args.Length;

                switch (numeroDeArgumentos)
                {
                    case 0:
                        Console.WriteLine("Nenhum argumento");
                        break;

                    case 1:
                        Console.WriteLine("Um argumento");
                        break;

                    default:
                        Console.WriteLine($"{numeroDeArgumentos} argumentos");
                        break;
                }
            }
            InstrucaoSwitch();
            */

            /*
            static void InstrucaoWhile()
            {
                string[] args = {"1", "2", "3"};
                int i = 0;

                while (i < args.Length)
                {   
                    Console.WriteLine(args[i]);
                    i++;
                }
            }
            InstrucaoWhile();
            */

            /*
            static void InstrucaoDo()
            {
                // string[] args = { "1", "2", "3" };
                string texto;

                do
                {   
                    Console.Write("Insira informações e dê enter para computar: ");
                    texto = Console.ReadLine();
                    Console.WriteLine(texto);
                } while (!string.IsNullOrEmpty(texto));
            }
            InstrucaoDo();
            */

            /*
            static void InstrucaoFor()
            {
                int[] args = { 1, 2, 3, 4, 5};
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            InstrucaoFor();
            */

            /*
            static void InstrucaoForeach()
            {
                int[] args = { 1, 2, 3, 4, 5};
                foreach (int numero in args)
                {
                    Console.WriteLine(numero);
                }
            }
            InstrucaoForeach();
            */

            /*
            static void InstrucaoBreak()
            {
                while (true)
                {   Console.Write("Informe dados: ");
                    string s = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("Não foi informado nenhum dado, saindo...");
                        break;
                    }

                    Console.WriteLine(s);
                }
            }
            InstrucaoBreak();
            */

            /*
            static void InstrucaoContinue()
            {
                string [] numero = {"1", "2", "3", "4", "5"};

                for (int i = 0; i < numero.Length ;i++)
                {
                    if (numero[i].StartsWith("1"))
                    {
                        continue;
                    }

                    Console.WriteLine(numero[i]);
                }
            }
            InstrucaoContinue();
            */

            /*
            static void InstrucaoReturn()
            {
                int Somar(int a, int b)
                {
                    return a + b;
                }

                Console.WriteLine(Somar(1, 2));
            }
            InstrucaoReturn();
            */

            /*
            static void InstrucaoTryCatchFinallyThrow()
            {
                try
                {
                    double Dividir(double x, double y)
                    {
                        if (y == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        return x / y;
                    }

                    Console.WriteLine(Dividir(2, 0));
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"Erro genérico: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Até breve!");
                }

            }
            InstrucaoTryCatchFinallyThrow();
            */

        }

    }

}