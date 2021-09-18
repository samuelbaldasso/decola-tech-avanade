using System;

namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Position first;
        public void Pile(object item) 
        {
            first = new Position(first, item);
        }

        public object Unpile() 
        {
            if (first == null)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            object result = first.item;
            first = first.next;
            return result;
        }
        
        class Position
        {
            public Position next;
            public object item;
            public Position(Position next, object item)
            {
                this.next = next;
                this.item = item;
            }
        }
    }
}