using System;

namespace CharacterRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // The character recognition software is misinterpreting text. 
            // Certain letters are being misinterpreted as numbers.
            // "S" is being misinterpreted as "5"
            // "O" is being misinterpreted as "0"
            // "I" is being misinterpreted as "1"
            // The Correct method should correct these specific mistakes when a string is past through.

            static string Correct(string text)
            {
                string correctedLetters = text.Replace("0", "O").Replace("5", "S").Replace("1", "I");
                return correctedLetters;
            }
            
            // Outputs "SINGAPORE"
            Console.WriteLine(Correct("51NGAP0RE"));
        }
    }
}
            
                
