var result = 0;
long target = 1_000_000_000;

long SumDivideBy(long number)
{
  var p = target / number;
  long teste = number * (p * (p+1)) / 2;
  return teste;
}
System.Console.WriteLine(SumDivideBy(3) + SumDivideBy(5) - SumDivideBy(15));
System.Console.WriteLine(SumDivideBy(3)); 
System.Console.WriteLine(SumDivideBy(5)); 
System.Console.WriteLine(SumDivideBy(15));
