using System;

namespace Plural
{
    class Program
    {
        static void Main(string[] args)
        {
           static bool Plural(double n)
           {
                return n != 1 ? true : false;
           }

           Console.WriteLine(Plural(0));
        }
    }
}
