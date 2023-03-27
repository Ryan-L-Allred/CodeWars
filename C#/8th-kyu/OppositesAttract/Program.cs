using System;

namespace OppositesAttract
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool lovefunc(int flower1, int flower2)
            {
                // If one flower has an odd number of petals and the other has an even number of petals, the couple is in love.
                // If the couple is in love, return true
                // Otherwise return false
                if (flower1 % 2 == 0 && flower2 % 2 != 0)
                {
                    return true;
                }
                else if (flower1 % 2 != 0 && flower2 % 2 == 0)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }

            Console.WriteLine(lovefunc(81, 75));
        }
    }
}
