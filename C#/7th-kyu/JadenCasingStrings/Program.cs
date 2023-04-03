using System;
using System.Globalization;

namespace JadenCasingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ToJadenCase(string phrase)
            {
                // Returns a string with the first character of each word capitalized.
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string titleCase = textInfo.ToTitleCase(phrase);
                return titleCase;
            }

            Console.WriteLine(ToJadenCase("the arsonist has oddly shaped feet."));
        }
    }
}
