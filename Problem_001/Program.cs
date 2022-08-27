//var result = 0;
long target = 1_000_000_000;

//for (int i = 0; i < 1000; i++)
//{
 //   if (i % 3 == 0 || i % 5 == 0)
//      result += i;
//}


long SumDivideBy(long number)
{
  var p = target / number;
  long teste = number * (p * (p+1)) / 2;
  return teste;
}
//System.Console.WriteLine(result);
System.Console.WriteLine(SumDivideBy(3) + SumDivideBy(5) - SumDivideBy(15));
System.Console.WriteLine(SumDivideBy(3)); 
System.Console.WriteLine(SumDivideBy(5)); 
System.Console.WriteLine(SumDivideBy(15));
