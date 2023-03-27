using System;

namespace SetAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool SetAlarm(bool employed, bool vacation)
            {
                if (employed == true && vacation == false) {
                    return true;
                } else {
                    return false;
                }
            }

            Console.WriteLine(SetAlarm(false, false));
        }
    }
}
