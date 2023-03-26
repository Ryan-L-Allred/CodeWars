using System;

namespace AreaOrPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            static int AreaOrPerimeter(int l, int w) 
            {
                // Given the length(l) and width(w) of a polygon, it can either be a square or rectangle
                // If it is a square, return the area
                // If it is a rectangle, return the perimeter
                if (l == w)
                {
                    return l * w;
                } else 
                {
                    return (l * 2) + (w * 2);
                }
            }
            
            // returns 84
            Console.WriteLine(AreaOrPerimeter(30, 12));
            
            // returns 81
            Console.WriteLine(AreaOrPerimeter(9, 9));
        }
    }
}
