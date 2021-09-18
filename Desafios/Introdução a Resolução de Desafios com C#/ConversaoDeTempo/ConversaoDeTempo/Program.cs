using System;


class Program
{
    static void Main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        int h = s / 3600;
        s = s % 3600;
        int m = s / 60;
        s = s % 60;


        Console.WriteLine($"{h}:{m}:{s}");
    }
}