﻿// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
//
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
// a  b  c  a  b  c   a   b   c   a
// resposta = 4613732
// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

int value = 4_000_000;
int total = 0;
int ant = 1;
int atual = 0;
int futuro = ant + atual;

while (futuro < value)
{
  ant = atual + futuro;
  atual = ant + futuro;
  futuro = ant + atual;
  total += atual;
}

Console.WriteLine(total);
