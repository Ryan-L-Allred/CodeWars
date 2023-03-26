using System;
using System.Collections.Generic;

namespace CountByX
{
    class Program
    {
        static void Main(string[] args)
        {
          static string AbbrevName(string name)
          {
            //Need to split both words at the space
            // 
            //string capitalized = name.ToUpper();
            string[] splitName = name.Split(' ');
            
            return (splitName[0][0] + "." + splitName[1][0]).ToUpper();
            
          }

          Console.WriteLine(AbbrevName("ryan lee allred"));

            // string name = "Ryan Allred";
            // string[] splitName = name.Split(' ');
            // foreach (string word in splitName)
            // {
            //     Console.WriteLine(word);
            // }
            
        }
    }
}
