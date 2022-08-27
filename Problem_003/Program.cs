// Largest prime factor
// Enviar

//  Show HTML problem content 
// Problem 3
// The prime factors of 13195 are 5, 7, 13 and 29.

// What is the largest prime factor of the number 600851475143 ?

using System;

namespace projeto_01
{
  class Program
  {
    static void Main(string[] args)
    {
      long Value = 600851475143;
      int PrimeFactor = 3;

      while (Value > 1)
      {
        if ((Value % PrimeFactor != 0) )
        {
          PrimeFactor = NextPrime(++PrimeFactor);
        }
        else
        {
          Value /= PrimeFactor;
        }
      }

      System.Console.WriteLine($"{PrimeFactor}");
    }

    public static int NextPrime(int prime)
    {
      int value = prime;
      while (!IsPrime(value))
        value++;
      return value;
    }

    public static bool IsPrime(int value)
    { 
      int count = 2;
      int number = value / 2 + 1;

      while (count < number)
      {
        if (value % count == 0)
          return false;
        count++;
      }
      return true;
    }
  }
}
