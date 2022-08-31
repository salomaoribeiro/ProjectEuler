// See https://aka.ms/new-console-template for more information

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

var result = true;
var value = 20;
var valid = false;

while(!valid)
{
  value += 2;
  result = true;

  for (int i = 2; i <= 20; i++)
  {
    if (value % i != 0)
    {
      result = false;
      break;
    }
  }
  if (result)
  {
    valid = true;
    break;
  }
}
Console.WriteLine($"{value}");
