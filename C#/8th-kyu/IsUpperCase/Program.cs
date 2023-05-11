// See https://aka.ms/new-console-template for more information
static bool IsUpperCase(string text)
{
    string capitalString = text.ToUpper();
    return text.Contains(capitalString) ? true : false;
}

Console.WriteLine(IsUpperCase("RYAn"));