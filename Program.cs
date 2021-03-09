using System;

namespace การบ้านโค้ดครั้งที่3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your mode : ");
            string mode = Console.ReadLine();
            Console.Write("Input your x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input your y : ");
            double y = double.Parse(Console.ReadLine());
            double t = Math.Sqrt(y) + 1;
            double p = Math.Pow((x - 1), 2);

            if (x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }
            else if (x >= 0)
            {
                if (mode == "time")
                {
                    Console.WriteLine("{0}, {1}", x, p);
                }
                else if (mode == "price")
                {
                    Console.WriteLine("{0}, {1}", t, y);
                }
                else
                {
                    Console.WriteLine("Invalid mode");
                }
            }

            Console.ReadLine();


        }
    }
}
