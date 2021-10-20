using System;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, a, b;
            int day = 1;
            h = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int speed = a - b;
            while (day * speed + a < h)
            {
                day++;
            }
            if(a < h)
            day++;
            Console.WriteLine(day);
        }
    }
}
