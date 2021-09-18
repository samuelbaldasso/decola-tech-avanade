using System;

class Program
{

    public static void Main()
    {
        int n;
        n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i<=n; i++)
        {
            if (i % 2 == 0)
            {
            }
            else 
            {
                Console.WriteLine($"{i}");
            }
        }

        Console.ReadLine();
    }

}