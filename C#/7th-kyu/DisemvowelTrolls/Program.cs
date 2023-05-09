//Function accepts a string as an argument and should return that string with all vowels removed
//Check if string contains particular vowels
static string Disemvowel(string str)
{
    var charsToRemove = new string[] {"A", "a", "E", "e", "I", "i", "O", "o", "U", "u"};
    foreach (var c in charsToRemove)
    {
        str = str.Replace(c, string.Empty);
    }
    return str;
}

Console.WriteLine(Disemvowel("You suck"));//Expected output: "ppl"