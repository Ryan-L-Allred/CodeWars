using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    // If the number is more than zero, it will change it to a negative integer. 
    // If number is already a negative integer, it will return the number as is.
    if (number > 0)
    {
        return -number;
    } else 
    {
        return number;
    }
  }
}