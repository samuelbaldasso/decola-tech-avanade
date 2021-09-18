using System;

namespace Instrucoes
{
    class Program
    {
        static void Declarations()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstructionIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento.");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento.");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos.");
            }
        }

        static void InstructionSwitch(string[] args)
        {
            int numberOfArgs = args.Length;
            switch (numberOfArgs)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento.");
                    break;
                case 1:
                    Console.WriteLine("Um argumento.");
                    break;
                default:
                    Console.WriteLine($"{numberOfArgs} argumentos.");
                    break;
            }
        }

        static void InstructionWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstructionDo(string[] args)
        {
            string text;
            do
            {
               text = Console.ReadLine();
                Console.WriteLine(text);
            } while (!string.IsNullOrEmpty(text));
        }

        static void InstructionFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstructionForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstructionBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine(s);
            }
        }

        static void InstructionContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                
                Console.WriteLine(args[i]);
            }
        }

        static void InstructionReturn(string[] args)
        {
            int Sum(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(3, 4));
            Console.WriteLine(Sum(5, 6));
            return;
        }

        static void InstructionsTryCatchFinallyThrow(string[] args)
        {
            double Divide(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
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

        static void InstructionUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
