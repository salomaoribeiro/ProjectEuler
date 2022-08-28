// See https://aka.ms/new-console-template for more information
//Largest palindrome product

//Problem 4
//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

//Find the largest palindrome made from the product of two 3-digit numbers.

int value = 999;
int botom = 100;
string result = "";
var resposta = 0;

while (value >= botom)
{
  int contador = 999;
  var palindrome = true;

  while (contador >= botom)
  {
    palindrome = true;
    result = (value * contador).ToString();
    
    var length = result.Length;
    var media = length / 2;

    for (var i = 0; i < media; i++)
    {
      if (result[i] != result[--length])
      {
        palindrome = false;
        break;
      }
    }

    if (palindrome && int.Parse(result) > resposta)
      resposta = int.Parse(result);

    contador--;
  }
  
  if (palindrome && int.Parse(result) > resposta)
  {
    resposta = int.Parse(result);
  }

  value--;
}

System.Console.WriteLine(resposta);

