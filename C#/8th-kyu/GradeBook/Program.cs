using System.Linq;
//We want the average of the three numbers being used as parameters.
//Return a character from A to F, depending on the average.
//Any score below 60 is an F. 60-69 = D, 70-79 = C, 80-89 = B, 90-99 = A
//Always capital.
//Find sum of all three parameters.
//Divide by three.
static char GetGrade(int s1, int s2, int s3) 
{
    int sum = s1 + s2 + s3;
    int average = sum / 3;

    if (average >= 90 && average <= 100) 
    {
        return 'A';
    } 
    else if (average >= 80 && average < 90)
    {
        return 'B';
    } 
    else if (average >= 70 && average < 80) 
    {
        return 'C';
    } 
    else if (average >= 60 && average < 70)
    {
        return 'D';
    } 
    else 
    {
        return 'F';
    }
    
}

Console.WriteLine(GetGrade(30, 50, 60)); //Expected output: B
//Console.WriteLine(GetGrade(59, 59, 59)); //Expected output: F