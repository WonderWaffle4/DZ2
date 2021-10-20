using System;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, newnum;
            newnum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                newnum += num % 10;
                newnum *= 10;
                num /= 10;
            }
            Console.WriteLine(newnum / 10);
        }
    }
}
