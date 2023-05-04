using System;

namespace AbbreviateName
{
    class Program
    {
        static void Main(string[] args)
        {
          DateTime startDate = new DateTime(2022, 3, 5);
            static string AbbrevName(string name)
          {
            //Need to split both words at the space
            // git 
            string[] splitName = name.Split(' ');
            
            return (splitName[0][0] + "." + splitName[1][0]).ToUpper();
            
          }

          Console.WriteLine(AbbrevName("ryan allred"));
        }
    }
}
