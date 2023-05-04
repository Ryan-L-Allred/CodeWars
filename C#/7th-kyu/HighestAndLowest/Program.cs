using System;
using System.Linq;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] InvertValues(int[] input) 
            {
                return input.Select(n => -n).ToArray();
            }
            int[] numbers = {2, -5, 7, -15};
            Console.WriteLine(InvertValues(new int[] {2, -5, 7, -15}));
            
        }
    }
}
