using System;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n % 100 / 10);
        }
    }
}
