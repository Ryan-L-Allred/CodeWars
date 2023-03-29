using System;

namespace SimpleMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Multiply(int x)
            {
                if (x % 2 == 0)
                {
                    return x * 8;
                } 
                else
                {
                    return x * 9;
                }
            }

            Console.WriteLine(Multiply(3));
        }
    }
}
