using System;

namespace TwiceAsOld
{
    class Program
    {
        static void Main(string[] args)
        {
            static int TwiceAsOld(int dadYears, int sonYears)
            {
                return Math.Abs(dadYears - sonYears * 2);
            }

            Console.WriteLine(TwiceAsOld(50, 31));
        }
    }
}
