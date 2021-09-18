namespace Classes.Metodos
{
    public class Ref
    {
        static void Invert(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Invert()
        {
            int i = 1, j = 2;
            Invert(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}