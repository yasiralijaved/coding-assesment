using System;

namespace CoderByte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--START Program 1--");
            new Program1().Execute();
            Console.WriteLine("--END Program 1--");


            Console.WriteLine("--START Program 2--");
            new Program2().Execute();
            Console.WriteLine("--END Program 2--");


            Console.WriteLine("--START Program 3--");
            new Program3().Execute();
            Console.WriteLine("--END Program 3--");
        }
    }
}
