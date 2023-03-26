using System;

namespace AreaOrPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            static int AreaOrPerimeter(int l, int w) 
            {
                // code goes here
                if (l == w)
                {
                    return l * w;
                } else 
                {
                    return (l * 2) + (w * 2);
                }
            }

            Console.WriteLine(AreaOrPerimeter(5, 6));
        }
    }
}
