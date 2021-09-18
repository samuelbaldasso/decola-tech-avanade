using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var stack = new Pilha();
            stack.pile(1);
            stack.pile(10);
            stack.pile(100);
            Constackole.WriteLine(stack.Unpile());
            Console.WriteLine(stack.Unpile());
            Console.WriteLine(stack.Unpile());
        }
    }
}
