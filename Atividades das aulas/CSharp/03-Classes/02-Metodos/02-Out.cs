namespace Classes.Metodos
{
    public class Out
    {
        static void Divide(int x, int y, out int result, out int rest) 
        {
            result = x / y;
            rest = x % y;
        }
        
        public static void Dividir() 
        {
            Dividir(10, 3, out int result, out int rest);
            System.Console.WriteLine("{0} {1}", result, rest);	// Escreve "3 1"
        }
    }
}