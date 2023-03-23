using System;

namespace stringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            static int StringToNumber(string str){
                return int.Parse(str);
            }
            Console.WriteLine(StringToNumber("24"));
            Console.WriteLine("24");
        }
    }
}
