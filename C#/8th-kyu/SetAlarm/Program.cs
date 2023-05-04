using System;

namespace SetAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // Write a function named setAlarm which receives two parameters. 
            // The first parameter, employed, is true whenever you are employed. 
            // The second parameter, vacation is true whenever you are on vacation.
            // The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). 
            // It should return false otherwise.
            // static bool SetAlarm(bool employed, bool vacation)
            // {
            //     if (employed == true && vacation == false) {
            //         return true;
            //     } else {
            //         return false;
            //     }
            // }
            
            // // Returns false
            // Console.WriteLine(SetAlarm(false, false));
            // // Returns true
            // Console.WriteLine(SetAlarm(true, false));
            int i =1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
