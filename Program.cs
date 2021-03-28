using System;

namespace ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("input a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("input b : ");
            b = int.Parse(Console.ReadLine());
            int x = a, y = b;

            do
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            while (x != y);
            {
                Console.Write("{0}", x);
            }
            Console.ReadLine();
        }
    }
}
